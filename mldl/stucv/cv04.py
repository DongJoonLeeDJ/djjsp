import cv2
import numpy as np

mainimg = cv2.imread('../videocap/dra.jpg')
mainimg = cv2.resize(mainimg,(640,480))
cv2.imshow('mainimg',mainimg)
cv2.waitKey(0)
print(mainimg.shape)

furimg = cv2.imread('../videocap/dog.jpg')
furimg = cv2.resize(furimg,(640,480))
cv2.imshow("furimg",furimg)
cv2.waitKey(0)
print(furimg.shape)

result1 = cv2.add(mainimg,furimg)
cv2.imshow("result1",result1)
cv2.waitKey(0)

result2 = np.add(mainimg,furimg)
cv2.imshow("result2",result2)
cv2.waitKey(0)