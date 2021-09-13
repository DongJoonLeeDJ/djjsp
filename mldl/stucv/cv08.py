import cv2 as cv

# 원래 이미지 보여주기
img_color = cv.imread('../contour/test.png')
# cv.imshow("img_color",img_color)
# cv.waitKey(0)

# gray 이미지 보여주기
img_gray = cv.cvtColor(img_color, cv.COLOR_BGR2GRAY)
# cv.imshow("img_gray",img_gray)
# cv.waitKey(0)

#이진화 처리해서 보여주기
ret, img_binary = cv.threshold(img_gray, 127, 255, 0)
# cv.imshow("img_binary",img_binary)
# cv.waitKey(0)

contours, hierarchy = cv.findContours(img_binary, cv.RETR_LIST, cv.CHAIN_APPROX_SIMPLE)


for cnt in contours:
    cv.drawContours(img_color, [cnt], 0, (255, 0, 0), 1)  # blue

cv.imshow("result", img_color)
cv.waitKey(0)

for cnt in contours:
    area = cv.contourArea(cnt)
    print(area)

cv.destroyAllWindows()

