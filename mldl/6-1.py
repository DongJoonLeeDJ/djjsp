import numpy as np
import matplotlib.pyplot as plt

fruits = np.load('fruits_300.npy')
print(fruits.shape)

print(fruits[0,:,:])

# plt.imshow(fruits[99],cmap='gray_r')
# plt.show()

fig,axis = plt.subplots(1,2)
axis[0].imshow(fruits[100],cmap='gray_r')
axis[1].imshow(fruits[200],cmap='gray_r')
# plt.show()

plt.savefig('fru.jpg')
plt.close()

# 1. 스프링 게시판 짜는거 보여주고..
# 2. 이미지 픽셀 분석하기
# 3. 웹페이지 와인데이터 입력해서 레드와인이지 화이트와인이지
#    - 0이면 레드와인.. 1이면 화이트와인이다..
# 월요일날..