import cv2

image = cv2.imread('main.jpg',cv2.IMREAD_COLOR)
print(image.shape)

cv2.imshow('title',image)
askey = cv2.waitKey(0)
print('askey',askey)

cv2.imwrite('main_copy.jpg',image)

image_gray = cv2.cvtColor(image,cv2.COLOR_BGR2GRAY)
cv2.imshow('image_gray',image_gray)
cv2.waitKey(0)
cv2.imwrite('main_gray.jpg',image_gray)

''' 
b g r 
b = 0 파랑색 없애라...
b = 255 파랑색 강하게... 
'''
# image[ : , : , 0] = 255
image[:,:,1] = 255
# image[:,:,2] = 255
cv2.putText(image,'Hello',(50,100),cv2.FONT_ITALIC,2,2)

cv2.imshow('title',image)
cv2.waitKey(0)
cv2.imwrite('main_blue.jpg',image)


cv2.destroyAllWindows()