import math
toplam, cikarma = 0, 0
dizi = []
for i in range(1000000):
    dizi[i]  = 1/(2 * i + 1)

    if i % 2 == 0:
        toplam += dizi[i]
    else:
        cikarma += dizi[i]
sonuc = 4 * (toplam - cikarma)
print("Pi Sayısı : " + math.pi)
print("Bizim Ulaştığımız Sonuç : " + sonuc)
print("İkisi Arasındaki Fark : " + (math.pi - sonuc))