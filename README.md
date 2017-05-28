# WeatherStation: Explore World's weather!
Развиено од: Филип Деспотовски и Александар Деспотовски.
# Опис на апликацијата
WeatherStation е едноставна апликација за прегледување на временската прогноза за речиси сите места во светот. Со избор на посакуваниот град се добива тековна временска прогноза, како и прогноза за наредните седум дена. Информациите се добиваат со помош на OpenWeatherMap API, кое е бесплатно API за временски услуги. Искористени се Current weather data и 16 day / daily forecast услугите.
# Кориснички интерфејс
WeatherStation се одликува со едноставен кориснички интерфејс, кој се состои еден главен прозорец. Во него централно место зазема сликичка која го опишува и се менува во зависност од времето и околу неа се распоредени сите останати информации. Во десната страна на прозорецот се наоѓа седумдневната прогноза во форма на листа од контроли, за секој ден по една. Горе во прозорецот се наоѓа лентата за мени, која нуди избор помеѓу Settings и Help. Долу може да се забележат полето за внесување град, копчиња за избор на единици мерки и копчето за обновување/преземање на временската прогноза.  
  
![](https://photos-2.dropbox.com/t/2/AAA0gmQLf8rjvIIQKn8nIXZSALVl8gliDfdnUkNYqe2EiA/12/25587124/png/32x32/1/_/1/2/weatherStation2.PNG/EKv9oRMY8QEgAigC/E-geDmNpGe5kqMToALxTlxMHNSOD1jLEaWKcd9H-L6w?size=1280x960&size_mode=3)  
# Функционалност
WeatherStation се одликува со неколку функции, од кои најважна е пребарувањето на градови. Истата е едноставно имплементирана: корисникот го впишува името на посакуваниот град во полето за внесување на текст и го притиска копчето Get Weather. Ако внесениот град постои или е успешно пронајден, се добиваат податоци за временската прогноза и погледот се освежува, во спротивно корисникот е известен дека бараниот град не е пронајден и не се случува ништо. 
  
![](https://photos-1.dropbox.com/t/2/AADmoj55-HgL2HYSBhQElN3ZW9tgH1owQrk_VvRYyt897g/12/25587124/png/32x32/1/_/1/2/weatherStation6.PNG/EKv9oRMY8QEgAigC/tuGcZapT_9xBaaivE7P4EC_SkArlRzU_apmyMTb4K_E?size=1280x960&size_mode=3)
  
Исто така корисникот може да одбере со кои мерни единици да бидат претставени мерењата, одбирајќи еден од два понудени избора (Imperial, Metric).
Доколку корисникот сака да го освежи постоечкото мерење за веќе внесен град, истото може да го направи со притискање на истото копче за внесување град, кое додека полето за внесување град е празно и веќе е внесен некој град, служи за освежување на мерењето на внесениот град и се води под името Update Weather.
  
![](https://photos-6.dropbox.com/t/2/AADLcPr3jtI215RXPjQ95siu2IbER9xQ17fE-igYFPhkmA/12/25587124/png/32x32/1/_/1/2/weatherStation3.PNG/EKv9oRMY8QEgAigC/foMrGhPD4Uhks3Pcgrsdur-GcFnS1plAGyebISU8Ty4?size=1280x960&size_mode=3)
  
Лентата за мени нуди две опции: Settings и Help. Во Settings може да се постават опции за автоматско освежување на прогнозата, временскиот интервал на кој ќе се освежува и дали при уклучување на програмата ќе се освежат мерењата.
  
![](https://photos-3.dropbox.com/t/2/AACWWRZJK5W23Zsz8l3NlVf7vitfd_q3VY4R0Encdbhnxw/12/25587124/png/32x32/1/_/1/2/weatherStation4.PNG/EKv9oRMY8QEgAigC/VVDCeJhYMlGENqtWXKDT143SAoL5PM_ZRaaoyNV12hQ?size=1280x960&size_mode=3)
  
Во Help може да се најдат дополнителни информации за проектот и неговите развивачи.
  
![](https://photos-5.dropbox.com/t/2/AACfh1-00UBlpS3l-aV0YvAtGRnJ75HegpxyF7zuVtWg1w/12/25587124/png/32x32/1/_/1/2/weatherStation5.PNG/EKv9oRMY8QEgAigC/Z7DXdJmPPkYTCKYmq9B2UNauZdL3-A8vA-XGPw4-eD0?size=1280x960&size_mode=3)
  
При стартување програмата прво пробува да ги прочита подесувањата за автоматско освежување (ако постојат) и потоа да го отвори претходното мерење (ако постои). Ако успее да го прочита претходното мерење, го освежува мерењето (ако е така подесено) и го освежува погледот. Во спротивно, корисникот се известува дека мерењето не е пронајдено и погледот се поставува на подразбирани вредности.
  
![](https://photos-5.dropbox.com/t/2/AACk7BJl88yXthFDzxBn58n4diYFP1wgkM78H4w5lhFxYg/12/25587124/png/32x32/1/_/1/2/errorLoadingData.PNG/EKv9oRMY8QEgAigC/8vAeSJh5FTb5r2VTH-ZJk7Iw-Knf8Wlio9vuEQOuA0o?size=1280x960&size_mode=3)
  
![](https://photos-4.dropbox.com/t/2/AACMhAkLZCadsX2FnPL5QDyOaHVOLisHHnRlLcZTH0K2uA/12/25587124/png/32x32/1/_/1/2/weatherStation1.PNG/EKv9oRMY8QEgAigC/blq_LGhBUbCeU8f7l43exr_04QiFG4JcFBJbmkcJFGc?size=1280x960&size_mode=3)
  
При секое успешно извршено мерење програмата го зачувува истото во бинарен документ, за при исклучување и повторно уклучување на програмата истото може да биде вчитано. Подесувањата за автоматско освежување се исто така зачувани во посебен бинарен документ при секоја успешна промена.
  
![](https://photos-1.dropbox.com/t/2/AAB_6yHjVsM1fcJ9sg-cOmiO-WDq6LTVAuG2SoQzLsAM2w/12/25587124/png/32x32/1/_/1/2/weatherStation7.PNG/EKv9oRMY8QEgAigC/ZeWVvEsMohKAflvzJG4CEIG-YqUHh-vFLE2PBvkizbQ?size=1280x960&size_mode=3)
# Имплементација
