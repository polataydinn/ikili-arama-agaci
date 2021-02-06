using System;
using System.Windows.Forms;

namespace agacOdev
{
    internal class agac
    {
        public static int[] dizi = new int[50];
        public static int[] solYaprakDizi = new int[50];
        public static int[] sagYaprakDizi = new int[50];
        public static int[] yaprakDizi = new int[50];
        public int diziSayi;
        public int yaprakSayi;
        public int solSayi;
        public int sagSayi;
        public void setDizi(int a,int b){
            dizi[b] = a;
        }

        public int getDizi(int a)
        {
            return dizi[a];
        }

        public void setYaprakDizi(int a, int b)
        {
            yaprakDizi[a] = b;
        }

        public int getYaprakDizi(int a)
        {
            return yaprakDizi[a];
        }

        public void setSolYaprakDugum(int a, int b)
        {
            solYaprakDizi[b] = a;
        }

        public int getSolYaprakDugum(int a)
        {
            return solYaprakDizi[a];
        }

        public void setSagYaprakDugum(int a, int b)
        {
            sagYaprakDizi[b] = a;
        }

        public int getSagYaprakDugum(int a)
        {
            return sagYaprakDizi[a];
        }

        public void yapraklarBul(Dugum dugum)
        {
            if (dugum == null)
                return;

            if (dugum.solDugum == null && dugum.sagDugum == null) { 
                setYaprakDizi(yaprakSayi, dugum.veri);
                yaprakSayi++;
            }
            if (dugum.solDugum != null)
                yapraklarBul(dugum.solDugum);

            if (dugum.sagDugum != null)
                yapraklarBul(dugum.sagDugum);
        }

        public Dugum Root { get; set; }

        public int getDugumDerece(Dugum dugum, int veri, int derece){
        if (dugum == null)
            return 0;
 
        if (dugum.veri == veri)
            return derece;
 
        int downlevel = getDugumDerece(dugum.solDugum, veri, derece + 1);
        if (downlevel != 0)
            return downlevel;
 
        downlevel = getDugumDerece(dugum.sagDugum, veri, derece + 1);
            return downlevel;
    }

        public int getDerece( Dugum  dugum, int veri){
        return getDugumDerece(dugum, veri, 1);
    }

        public bool ekle(int deger)
        {
            Dugum before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (deger < after.veri) //Is new node in left tree? 
                    after = after.solDugum;
                else if (deger > after.veri) //Is new node in right tree?
                    after = after.sagDugum;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Dugum newNode = new Dugum();
            newNode.veri = deger;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (deger < before.veri)
                    before.solDugum = newNode;
                else
                    before.sagDugum = newNode;
            }

            return true;
        }

        public void sil(int deger)
        {
            this.Root = sil(this.Root, deger);
        }

        private Dugum sil(Dugum dugum, int anahtar)
        {
            if (dugum == null) return dugum;

            if (anahtar < dugum.veri) dugum.solDugum = sil(dugum.solDugum, anahtar);
            else if (anahtar > dugum.veri)
                dugum.sagDugum = sil(dugum.sagDugum, anahtar);

            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (dugum.solDugum == null)
                    return dugum.sagDugum;
                else if (dugum.sagDugum == null)
                    return dugum.solDugum;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                dugum.veri = enDusukDeger(dugum.sagDugum);

                // Delete the inorder successor  
                dugum.sagDugum = sil(dugum.sagDugum, dugum.veri);
            }

            return dugum;
        }

        private int enDusukDeger(Dugum dugum)
        {
            int minv = dugum.veri;

            while (dugum.solDugum != null)
            {
                minv = dugum.solDugum.veri;
                dugum = dugum.solDugum;
            }

            return minv;
        }

        public int agacYukseklik()
        {
            return this.getAgacYukseklik(this.Root);
        }

        public int getRoot(Dugum dugum)
        {
            return dugum == null ? 0 : dugum.veri;
        }

        private int getAgacYukseklik(Dugum dugum)
        {
            return dugum == null ? 0 : Math.Max(getAgacYukseklik(dugum.solDugum), getAgacYukseklik(dugum.sagDugum)) + 1;
        }

        public void preOrder(Dugum dugum)
        {
            if (dugum != null)
            {
                setDizi(dugum.veri, diziSayi);
                diziSayi++;
                preOrder(dugum.solDugum);
                 preOrder(dugum.sagDugum);

            }
        }

        public void inOrder(Dugum dugum)
        {
            if (dugum != null)
            {
                inOrder(dugum.solDugum);
                setDizi(dugum.veri, diziSayi);
                diziSayi++;
                inOrder(dugum.sagDugum);

            }
        }

        public void postOrder(Dugum dugum)
        {
            if (dugum != null)
            {
                postOrder(dugum.solDugum);
                postOrder(dugum.sagDugum);
                setDizi(dugum.veri, diziSayi);
                diziSayi++;
            }
        }

        public void solYapraklar(Dugum dugum)
        {
            if(dugum != null)
            {
                solYapraklar(dugum.solDugum);
                setSolYaprakDugum(dugum.veri,solSayi);
                solSayi++;
            }
        }

        public void sagYapraklar(Dugum dugum)
        {
            if (dugum != null)
            {
                sagYapraklar(dugum.sagDugum);
                setSagYaprakDugum(dugum.veri, sagSayi);
                sagSayi++;
            }
        }
    }
}