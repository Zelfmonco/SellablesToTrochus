using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    //-----sellables-----//
    //$3 sellables
    int AreolataValue = 3;
    int BoneValue = 3;
    int FootValue = 3;
    int HandValue = 3;

    //$4 sellables
    int PaperValue = 4;
    int NewspaperValue = 4;
    int EyesValue = 4;

    //$5 sellables
    int SandDollarValue = 5;
    int ScallopValue = 5;
    int BrokenBottleValue = 5;
    int MushroomValue = 5;
    int BrainValue = 5;
    int HeartValue = 5;
    int OtherMineralsValue = 5;

    //$6 sellables
    int CrabShellValue = 6;
    int OldTireValue = 6;

    //$7 sellables
    int StarfishValue = 7;
    int RubyValue = 7;
    int SapphireValue = 7;

    //$8 sellables
    int EmeraldValue = 8;

    //$10 sellables
    int GoldValue = 10;
    int DiamondValue = 10;

    //-------groups-------//
    public TMP_InputField Areolata;
    public TMP_InputField Bone;
    public TMP_InputField Foot;
    public TMP_InputField Hand;
    public TMP_InputField Paper;
    public TMP_InputField Newspaper;
    public TMP_InputField Eyes;
    public TMP_InputField SandDollar;
    public TMP_InputField Scallop;
    public TMP_InputField BrokenBottle;
    public TMP_InputField MushroomRed;
    public TMP_InputField MushroomPurple;
    public TMP_InputField MushroomYellow;
    public TMP_InputField MushroomPlain;
    public TMP_InputField Heart;
    public TMP_InputField Brain;
    public TMP_InputField CrabShellYellow;
    public TMP_InputField CrabShellBlack;
    public TMP_InputField CrabShellRed;
    public TMP_InputField CrabShellBlue;
    public TMP_InputField CrabShellGreen;
    public TMP_InputField OldTire;
    public TMP_InputField Starfish;
    public TMP_InputField Sapphire;
    public TMP_InputField Ruby;
    public TMP_InputField Emerald;
    public TMP_InputField Gold;
    public TMP_InputField Diamond;
    public TMP_InputField Iron;
    public TMP_InputField Lead;
    public TMP_InputField Silver;
    public TMP_InputField Copper;
    public TMP_InputField Quartz;
    public TMP_InputField Gypsum;

    public TMP_InputField ratioInput;

    public TMP_Text value;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Calculate()
    {
        ValidateInputs();

        int areolata = int.Parse(Areolata.text ?? "0") * AreolataValue;
        int sandDollar = int.Parse(SandDollar.text ?? "0") * SandDollarValue;
        int scallop = int.Parse(Scallop.text ?? "0") * ScallopValue;
        int starfish = int.Parse(Starfish.text ?? "0") * StarfishValue;
        int brokenBottle = int.Parse(BrokenBottle.text ?? "0") * BrokenBottleValue;
        int newspaper = int.Parse(Newspaper.text ?? "0") * NewspaperValue;
        int oldTire = int.Parse(OldTire.text ?? "0") * OldTireValue;
        int paper = int.Parse(Paper.text ?? "0") * PaperValue;
        int mushroomPlain = int.Parse(MushroomPlain.text ?? "0") * MushroomValue;
        int mushroomRed = int.Parse(MushroomRed.text ?? "0") * MushroomValue;
        int mushroomYellow = int.Parse(MushroomYellow.text ?? "0") * MushroomValue;
        int mushroomPurple = int.Parse(MushroomPurple.text ?? "0") * MushroomValue;
        int brain = int.Parse(Brain.text ?? "0") * BrainValue;
        int bone = int.Parse(Bone.text ?? "0") * BoneValue;
        int eyes = int.Parse(Eyes.text ?? "0") * EyesValue;
        int foot = int.Parse(Foot.text ?? "0") * FootValue;
        int hand = int.Parse(Hand.text ?? "0") * HandValue;
        int heart = int.Parse(Heart.text ?? "0") * HeartValue;
        int diamond = int.Parse(Diamond.text ?? "0") * DiamondValue;
        int emerald = int.Parse(Emerald.text ?? "0") * EmeraldValue;
        int gold = int.Parse(Gold.text ?? "0") * GoldValue;
        int ruby = int.Parse(Ruby.text ?? "0") * RubyValue;
        int sapphire = int.Parse(Sapphire.text ?? "0") * SapphireValue;
        int iron = int.Parse(Iron.text ?? "0") * OtherMineralsValue;
        int lead = int.Parse(Lead.text?? "0") * OtherMineralsValue;
        int silver = int.Parse(Silver.text ?? "0") * OtherMineralsValue;
        int copper = int.Parse(Copper.text ?? "0") * OtherMineralsValue;
        int quatrz = int.Parse(Quartz.text ?? "0") * OtherMineralsValue;
        int gypsum = int.Parse(Gypsum.text ?? "0") * OtherMineralsValue;
        int crabBlack = int.Parse(CrabShellBlack.text ?? "0") * CrabShellValue;
        int crabBlue = int.Parse(CrabShellBlue.text ?? "0") * CrabShellValue;
        int crabGreen = int.Parse(CrabShellGreen.text ?? "0") * CrabShellValue;
        int crabRed = int.Parse(CrabShellRed.text ?? "0") * CrabShellValue;
        int crabYellow = int.Parse(CrabShellYellow.text ?? "0") * CrabShellValue;

        float ratio = float.Parse(ratioInput.text);
        
        float troFloat = (areolata + sandDollar + scallop + starfish + brokenBottle + newspaper + oldTire + paper + mushroomPlain + mushroomPurple + mushroomRed + mushroomYellow
            + brain + bone + eyes + foot + hand + heart + diamond + emerald + gold + ruby + sapphire + crabBlack + crabBlue + crabGreen + crabRed + crabYellow) / ratio;

        int tro = Mathf.RoundToInt(troFloat);
        value.text = tro.ToString();
    }

    public void ValidateInputs()
    {
        SetZeroIfEmpty(Areolata);
        SetZeroIfEmpty(Bone);
        SetZeroIfEmpty(Foot);
        SetZeroIfEmpty(Hand);
        SetZeroIfEmpty(Paper);
        SetZeroIfEmpty(Newspaper);
        SetZeroIfEmpty(Eyes);
        SetZeroIfEmpty(SandDollar);
        SetZeroIfEmpty(Scallop);
        SetZeroIfEmpty(BrokenBottle);
        SetZeroIfEmpty(MushroomRed);
        SetZeroIfEmpty(MushroomPurple);
        SetZeroIfEmpty(MushroomYellow);
        SetZeroIfEmpty(MushroomPlain);
        SetZeroIfEmpty(Heart);
        SetZeroIfEmpty(Brain);
        SetZeroIfEmpty(CrabShellYellow);
        SetZeroIfEmpty(CrabShellBlack);
        SetZeroIfEmpty(CrabShellRed);
        SetZeroIfEmpty(CrabShellBlue);
        SetZeroIfEmpty(CrabShellGreen);
        SetZeroIfEmpty(OldTire);
        SetZeroIfEmpty(Starfish);
        SetZeroIfEmpty(Sapphire);
        SetZeroIfEmpty(Ruby);
        SetZeroIfEmpty(Emerald);
        SetZeroIfEmpty(Gold);
        SetZeroIfEmpty(Diamond);
        SetOneIfEmptyOrZero(ratioInput);
        SetZeroIfEmpty(Iron);
        SetZeroIfEmpty(Lead);
        SetZeroIfEmpty(Silver);
        SetZeroIfEmpty(Copper);
        SetZeroIfEmpty(Quartz);
        SetZeroIfEmpty(Gypsum);

    }

    private void SetZeroIfEmpty(TMP_InputField field)
    {
        if (string.IsNullOrWhiteSpace(field.text))
        {
            field.text = "0";
        }
    }

    private void SetOneIfEmptyOrZero(TMP_InputField field)
    {
        if (string.IsNullOrWhiteSpace(field.text) || float.Parse(field.text) == 0)
        {
            field.text = "1";
        }
    }
}
