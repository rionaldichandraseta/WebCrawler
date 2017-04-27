﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebCrawler
{
    class GetKalimatInIndex
    {
    private string kataInput = "";
    private string kalimat = "";
    public GetKalimatInIndex(string kata)
    {
        kataInput = kata;
    }

    public string getKalimat(int index)
    {
        int awal = index;
        int akhir = index;
        //mencari index awal kalimat
        while(awal >= 0 && kataInput[awal]!='.')
        {
            awal--;
        }

        //mencari index akhir kalimat
        while (akhir <= kataInput.Length - 1 && kataInput[akhir] != '.')
        {
            akhir++;
        }

            if (akhir < 0) { akhir = 0; }
            if (akhir == kataInput.Length) { akhir--; }
        for(int i = awal+1; i<=akhir; i++)
        {
            kalimat += kataInput[i];
        }

        return kalimat;
    }
    }
}
