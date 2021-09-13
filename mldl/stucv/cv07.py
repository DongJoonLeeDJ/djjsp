import cv2
import numpy as np

image = np.full((300,512,3),255, np.uint8)
#putText (원래이미지,쓰고싶은글자,좌표,글자효과,글자크기,RGB)
image = cv2.putText(image,'parkmyounghoi',(0,150),cv2.FONT_ITALIC,1.5,(255,0,0))

cv2.imshow("IMAGE",image)
cv2.waitKey(0)