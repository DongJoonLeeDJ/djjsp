from KNeTest import getresult
from selenium import webdriver
import time
import urllib.request

web = webdriver.Chrome()
web.get('http://192.168.0.135:10000')

time.sleep(0.5)
web.find_element_by_xpath('/html/body/div[1]/div/div/blockquote/a').click()

for i in range(1,31):
    time.sleep(0.2)
    img = web.find_element_by_id('img'+str(i))
    src = img.get_attribute('src')
    # download the image
    urllib.request.urlretrieve(src, './examimg/img'+str(i)+'.png')
    time.sleep(0.2)
    result = getresult('./examimg/img'+str(i)+'.png')
    print(result)
    web.find_element_by_id('ans').send_keys(result)
    web.find_element_by_id('submit').click()

time.sleep(5)
web.quit()

# result = getresult('beforeimages/1.png')
# print(result)
#
# result = getresult('beforeimages/2.png')
# print(result)