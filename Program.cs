using System;

// Class Processor
class Processor
{
    public string Merk { get; set; }
    public string Tipe { get; set; }

    public Processor(string merk, string tipe)
    {
        Merk = merk;
        Tipe = tipe;
    }
}

// Class Intel dengan turunan dari Class Processor
class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
        if (string.IsNullOrEmpty(tipe))
        {
            throw new ArgumentException("Tipe processor tidak boleh kosong.");
        }
    }
}

// Class Corei3 dengan turunan dari Class Intel
class Corei3 : Intel
{
    public Corei3() : base("Corei3")
    {
    }
}

// Class Corei5 dengan turunan dari Class Intel
class Corei5 : Intel
{
    public Corei5() : base("Corei5")
    {
    }
}

// Class Corei7 dengan turunan dari Class Intel
class Corei7 : Intel
{
    public Corei7() : base("Corei7")
    {
    }
}

// Class AMD dengan turunan dari Class Processor
class AMD : Processor
{
    public AMD(string tipe) : base("AMD", tipe)
    {
        if (string.IsNullOrEmpty(tipe))
        {
            throw new ArgumentException("Tipe processor tidak boleh kosong.");
        }
    }
}

// Class Ryzen dengan turunan dari Class AMD
class Ryzen : AMD
{
    public Ryzen() : base("Ryzen")
    {
    }
}

// Class Athlon dengan turunan dari Class AMD
class Athlon : AMD
{
    public Athlon() : base("Athlon")
    {
    }
}

// Class VGA
class Vga
{
    public string merk;

    public Vga(string merk)
    {
        if (string.IsNullOrEmpty(merk))
        {
            throw new ArgumentException("Merk VGA tidak boleh kosong.");
        }
        this.merk = merk;
    }
}

// Class Nvidia dengan turunan dari Class VGA
class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    {
    }
}

// Class AMDVGA dengan turunan dari Class VGA
class AMDVGA : Vga
{
    public AMDVGA() : base("AMD")
    {
    }
}

// Class Laptop
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        if (string.IsNullOrEmpty(merk))
        {
            throw new ArgumentException("Merk tidak boleh kosong", nameof(merk));
        }
        if (string.IsNullOrEmpty(tipe))
        {
            throw new ArgumentException("Tipe tidak boleh kosong", nameof(tipe));
        }
        this.merk = merk;
        this.tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public string Merk
    {
        get { return merk; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                merk = value;
            }
            else
            {
                throw new ArgumentException("Nilai Merk tidak boleh kosong.", nameof(value));
            }
        }
    }

    public string Tipe
    {
        get { return tipe; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                tipe = value;
            }
            else
            {
                throw new ArgumentException("Nilai Tipe tidak boleh kosong.", nameof(value));
            }
        }
    }

    public Vga Vga
    {
        get { return vga; }
        set { vga = value; }
    }

    public Processor Processor
    {
        get { return processor; }
        set { processor = value; }
    }

    // Method LaptopDinyalakan
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }

    // Method LaptopDimatikan
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati\n");
    }
}

// Class ASUS dengan turunan dari Class Laptop
class ASUS : Laptop
{
    public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
    {
    }
}

// Class ROG dengan turunan dari Class ASUS
class ROG : ASUS
{
    public ROG(string v, Vga vga, Processor processor) : base("ROG", vga, processor)
    {
    }
}

// Class Vivobook dengan turunan dari Class ASUS
class Vivobook : ASUS
{
    public Vivobook(string v, Vga vga, Processor processor)
        : base("Vivobook", vga, processor)
    {
    }

    // Method Ngoding
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

// Class ACER dengan turunan dari Class Laptop
class ACER : Laptop
{
    public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
    {
    }
}

// Class Swift dengan turunan dari Class ACER
class Swift : ACER
{
    public Swift(string v, Vga vga, Processor processor) : base("Swift", vga, processor)
    {
    }
}

// Class Predator dengan turunan dari Class ACER
class Predator : ACER
{
    public Predator(string v, Vga vga, Processor processor)
        : base("Predator", vga, processor)
    {
    }

    // Method BermainGame
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

// Class Lenovo dengan turunan dari Class Laptop
class Lenovo : Laptop
{
    public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
    {
    }
}

// Class IdeaPad dengan turunan dari Class Lenovo
class IdeaPad : Lenovo
{
    public IdeaPad(string v, Vga vga, Processor processor) : base("IdeaPad", vga, processor)
    {
    }
}

// Class Legion dengan turunan dari Class Lenovo
class Legion : Lenovo
{
    public Legion(string v, Vga vga, Processor processor) : base("Legion", vga, processor)
    {
    }
}

// Class program
class Program
{
    static void Main(string[] args)
    {
        // Laptop 1
        Laptop laptop1 = new Vivobook("Vivobook", new Nvidia(), new Corei5());

        // Menampilkan Spesifikasi laptop1
        Console.WriteLine("Spesifikasi Laptop " + laptop1.Merk + " " + laptop1);
        Console.WriteLine("Merk VGA: " + laptop1.Vga.merk);
        Console.WriteLine("Merk Processor: " + laptop1.Processor.Merk);
        Console.WriteLine("Tipe Processor: " + laptop1.Processor.GetType().Name);
        Console.WriteLine("----------------------------------");

        // Memanggil method LaptopDinyalakan pada objek laptop1
        laptop1.LaptopDinyalakan();

        // Memanggil method Ngoding pada objek laptop1 (jika tipe laptop adalah Vivobook)
        if (laptop1 is Vivobook vivobook)
        {
            vivobook.Ngoding();
        }

        // Memanggil method LaptopDimatikan pada objek laptop1
        laptop1.LaptopDimatikan();

        // Laptop 2
        Laptop laptop2 = new IdeaPad("IdeaPad", new AMDVGA(), new Ryzen());

        // Menampilkan Spesifikasi laptop2
        Console.WriteLine("Spesifikasi Laptop " + laptop2.Merk + " " + laptop2);
        Console.WriteLine("Merk VGA: " + laptop2.Vga.merk);
        Console.WriteLine("Merk Processor: " + laptop2.Processor.Merk);
        Console.WriteLine("Tipe Processor: " + laptop2.Processor.GetType().Name);
        Console.WriteLine("----------------------------------");

        // Memanggil method LaptopDinyalakan pada objek laptop2
        laptop2.LaptopDinyalakan();

        // Memanggil method LaptopDimatikan pada objek laptop2
        laptop2.LaptopDimatikan();

        // Laptop Predator
        Predator predator = new Predator("Predator", new AMDVGA(), new Corei7());

        // Menampilkan Spesifikasi predator
        Console.WriteLine("Spesifikasi Laptop " + predator.Merk + " " + predator);
        Console.WriteLine("Merk VGA: " + predator.Vga.merk);
        Console.WriteLine("Merk Processor: " + predator.Processor.Merk);
        Console.WriteLine("Tipe Processor: " + predator.Processor.GetType().Name);
        Console.WriteLine("----------------------------------");

        // Memanggil method LaptopDinyalakan pada objek predator
        predator.LaptopDinyalakan();

        // Memanggil method BermainGame pada objek predator
        if (predator is Predator p)
        {
            p.BermainGame();
        }

        // Memanggil method LaptopDimatikan pada objek predator
        predator.LaptopDimatikan();

        // Soal no. 5
        // Laptop Acer
        ACER acer = new ACER("Acer", new AMDVGA(), new Corei7());

        // Menetapkan objek predator ke dalam variabel acer
        acer = predator;

        // Jalankan method BermainGame() pada objek predator yang diassign ke dalam variabel acer
        if (acer is Predator o)
        {
            o.BermainGame();
        }
    }
}
