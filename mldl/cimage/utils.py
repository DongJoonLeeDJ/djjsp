import cv2
import os

blue = 0
green = 1
red = 2

def get_chars(image, color):
    other1 = (color + 1) % 3    # 2
    other2 = (color + 2) % 3    # 0  -> green 1 other1 =red= 2 other2 =blue= 0
    bc = image[:, :, other1] == 255
    image[bc] = [0, 0, 0]
    bc = image[:, :, other2] == 255
    image[bc] = [0, 0, 0]
    bc = image[:, :, color] < 170
    image[bc] = [0, 0, 0]
    bc = image[:, :, color] != 0
    image[bc] = [255, 255, 255]
    return image


def extract_chars(filename):
    chars = []
    colors = [blue, green, red]
    for color in colors:    # 3번 도는 for
        image = cv2.imread(filename, cv2.IMREAD_COLOR)
        color_image = get_chars(image.copy(),color)
        gray_image = cv2.cvtColor(color_image, cv2.COLOR_BGR2GRAY)
        ret, thresh_image = cv2.threshold(gray_image, 127, 255, 0)
        cv2.imshow("threash_image",thresh_image)
        cv2.waitKey(0)
        coutours, _ = cv2.findContours(thresh_image, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

        for cnt in coutours:
            area = cv2.contourArea(cnt)
            if area > 50:
                x, y, w, h = cv2.boundingRect(cnt)
                # print('x',x);
                # print('y', y);
                # print('w', w);
                # print('h', h);
                roi = thresh_image[y:y + h, x:x + w]
                roi20 = cv2.resize(roi,(20,20))
                cv2.imshow("roi", roi20)
                input_number = cv2.waitKey(0)
                print(input_number)
                if input_number > 47 and input_number < 58:
                    dic_name = input_number - 48
                    file_name = len(next(os.walk('./train_data/1/'))[2]) + 1
                    cv2.imwrite('./train_data/'+str(dic_name)+'/'+str(file_name)+'.png',roi20)
                if input_number == 97:
                    print('+ 저장됨')
                    dic_name = '10'
                    file_name = len(next(os.walk('./train_data/1/'))[2]) + 1
                    cv2.imwrite('./train_data/' + str(dic_name) + '/' + str(file_name) + '.png', roi20)
                if input_number == 98:
                    print('- 저장됨')
                    dic_name = '11'
                    file_name = len(next(os.walk('./train_data/1/'))[2]) + 1
                    cv2.imwrite('./train_data/' + str(dic_name) + '/' + str(file_name) + '.png', roi20)
                if input_number == 99:
                    print('x 저장됨')
                    dic_name = '12'
                    file_name = len(next(os.walk('./train_data/1/'))[2]) + 1
                    cv2.imwrite('./train_data/' + str(dic_name) + '/' + str(file_name) + '.png', roi20)


extract_chars('beforeimages/1.png')
# extract_chars('beforeimages/2.png')
# extract_chars('beforeimages/3.png')
# extract_chars('beforeimages/5.png')
# extract_chars('beforeimages/6.png')
# extract_chars('beforeimages/7.png')
# extract_chars('beforeimages/8.png')
# extract_chars('beforeimages/9.png')
# extract_chars('beforeimages/10.png')
# extract_chars('beforeimages/11.png')
# extract_chars('beforeimages/12.png')
# extract_chars('beforeimages/13.png')


# print(file_name)

# sklearn knn 알고리즘
# 2차원배열로..
# [[1,2,3],[4,5,6]]


# extract_chars('a')
# extract_chars('a')

# color_image = cv2.imread('1.png', cv2.IMREAD_COLOR)
# extract_chars(color_image)
# cv2.imshow("color_image", color_image)
# cv2.waitKey(0)
#
# blue_image = get_chars(color_image.copy(), blue)
# extract_chars(blue_image)
# cv2.imshow("cha_image", blue_image)
# cv2.waitKey(0)
# #
# color_image = cv2.imread('./beforeimages/1.png', cv2.IMREAD_COLOR)
# green_image = get_chars(color_image.copy(), blue)
# cv2.imshow("cha_image", green_image)
# cv2.waitKey(0)
#
# red_image = get_chars(color_image.copy(), red)
# cv2.imshow("cha_image", red_image)
# cv2.waitKey(0)

'''

'''