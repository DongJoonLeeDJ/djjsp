import cv2

grayimg = cv2.imread('../videocap/main.jpg', cv2.IMREAD_GRAYSCALE)

glistimg = []

ret, thresh1 = cv2.threshold(grayimg, 40, 255, cv2.THRESH_BINARY)
ret, thresh2 = cv2.threshold(grayimg, 40, 255, cv2.THRESH_BINARY_INV)
ret, thresh3 = cv2.threshold(grayimg, 40, 255, cv2.THRESH_TRUNC)
ret, thresh4 = cv2.threshold(grayimg, 40, 255, cv2.THRESH_TOZERO)
ret, thresh5 = cv2.threshold(grayimg, 40, 255, cv2.THRESH_TOZERO_INV)

glistimg.append(thresh1)
glistimg.append(thresh2)
glistimg.append(thresh3)
glistimg.append(thresh4)
glistimg.append(thresh5)

# for i,img in zip(range(0,5),glistimg):
#     cv2.imshow("thres"+str(i), img)
#     cv2.waitKey(0)



meanimg = cv2.adaptiveThreshold(grayimg,
                                255,cv2.ADAPTIVE_THRESH_MEAN_C,cv2.THRESH_BINARY,11,5)
gaussianimg = cv2.adaptiveThreshold(grayimg,
                                    255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,cv2.THRESH_BINARY,11,5)

# cv2.imshow("meanimg",meanimg)
# cv2.waitKey(0)

# cv2.imshow("gaussianimg",gaussianimg)
# cv2.waitKey(0)


for i in range(1,100):
    gaussianimg = \
        cv2.adaptiveThreshold(grayimg,
            255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY, 11, i)
    cv2.imshow("gaussianimg", gaussianimg)
    cv2.waitKey(1)



