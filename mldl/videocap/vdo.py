import cv2
import sys

cap = cv2.VideoCapture(0)

if not cap.isOpened():
    print("Camera open failed!")
    sys.exit()

# 카메라 프레임 크기 출력
print('Frame width:', int(cap.get(cv2.CAP_PROP_FRAME_WIDTH)))
print('Frame height:', int(cap.get(cv2.CAP_PROP_FRAME_HEIGHT)))

# 카메라 프레임 처리
while True:
    ret, frame = cap.read()
    # print(frame.shape)
    if not ret:
        break

    # inversed = ~frame  # 반전
    gayimg = cv2.cvtColor(frame,cv2.COLOR_RGB2GRAY)
    gaussianimg = \
        cv2.adaptiveThreshold(gayimg,
                              255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY, 11, 2)\

    frame = cv2.putText(frame, 'parkmyounghoi', (0, 300), cv2.FONT_ITALIC, 2, (0, 0, 0))

    cv2.imshow('frame', frame)
    cv2.imshow('inversed', gaussianimg)
    # cv2.imwrite('a.jpg')

    if cv2.waitKey(10) == 27:
        break
    if cv2.waitKey(10) == 49:
        cv2.imwrite('gaussian_minyoung.jpg', gaussianimg)
        cv2.imwrite('minyoung.jpg', frame)
        print('saved')

cap.release() #사용한 자원 해제
cv2.destroyAllWindows()

'''
    c++,c# 
    
    opencv..
    분류.. 바코드... 
'''