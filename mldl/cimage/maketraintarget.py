import cv2
import os
import numpy as np
from sklearn.neighbors import KNeighborsClassifier

directorynames = list(range(0,13))

train=[]
target=[]

for direc in directorynames:    # 0 ~ 12
    # print(direc)
    # print(len(next(os.walk('./train_data/'+str(direc)))[2]))
    filecount = len(next(os.walk('./train_data/'+str(direc)))[2])
    print('direc',direc,'filecount',filecount)
    for file in range(0,filecount):
        filename = './train_data/'+str(direc)+'/'+str(file+1)+'.png'
        img = cv2.imread(filename,cv2.IMREAD_COLOR)
        gray_img = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
        # cv2.imshow('./train_data/'+str(file)+'png',gray_img)
        # cv2.waitKey(0)
        print('gray_img.reshape(-1,20*20).shape',gray_img.reshape(20*20).shape)
        train.append(gray_img.reshape(20*20))
        target.append(direc)
    # print(train[:4])
    # nptrain = np.array(train)
    # print(nptrain.shape)
    # print(target[:4])
#
# np.savez('traintarget.npz',train=train,target=target)
# train = np.load('traintarget.npz')['train']
# target = np.load('traintarget.npz')['target']
# print(train.shape)
# print(target.shape)
#
# knclf = KNeighborsClassifier()
# knclf.fit(train,target)
#
#
# filename = './train_data/0/1.png'
# img = cv2.imread(filename,cv2.IMREAD_COLOR)
# gray_img = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
# prvalue = knclf.predict([gray_img.reshape(20*20)])
# print(prvalue)
#
# filename = './train_data/1/1.png'
# img = cv2.imread(filename,cv2.IMREAD_COLOR)
# gray_img = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
# prvalue = knclf.predict([gray_img.reshape(20*20)])
# print(prvalue)
#
# filename = './train_data/1/2.png'
# img = cv2.imread(filename,cv2.IMREAD_COLOR)
# gray_img = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
# prvalue = knclf.predict([gray_img.reshape(20*20)])
# print(prvalue)