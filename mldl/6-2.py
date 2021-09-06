import numpy as np

from sklearn.cluster import KMeans
from sklearn.linear_model import LogisticRegression

from sklearn.model_selection import train_test_split
import matplotlib.pyplot as plt

# 2차원
# 300행 10000열

fruits = np.load('fruits_300.npy')
fruits_2d = fruits.reshape(-1, 100*100)
print(fruits_2d.shape)

km = KMeans(n_clusters=3, random_state=42)
km.fit(fruits_2d)   # 비지도 학습..

prevalue = km.predict([fruits_2d[0],fruits_2d[100],fruits_2d[200]])
print("target = ", prevalue)
#
plt.imshow(fruits_2d[0].reshape(100,100),cmap='gray_r')
plt.show()
plt.imshow(fruits_2d[100].reshape(100,100),cmap='gray_r')
plt.show()
plt.imshow(fruits_2d[200].reshape(100,100),cmap='gray_r')
plt.show()

# 0 사과 1파인애플 2 바나나
target = [0]*100+[1]*100+[2]*100

train_input,test_input,train_target,test_target \
    = train_test_split(fruits_2d,target,random_state=42)

lr = LogisticRegression()
lr.fit(train_input,train_target)    # 지도학습..

print(test_input[0].shape) # (1,10000)
prevalue = lr.predict([test_input[0],test_input[1],test_input[2]])
print("target = ", prevalue)
#
plt.imshow(test_input[0].reshape(100,100),cmap='gray_r')
plt.show()
plt.imshow(test_input[1].reshape(100,100),cmap='gray_r')
plt.show()
plt.imshow(test_input[2].reshape(100,100),cmap='gray_r')
plt.show()
