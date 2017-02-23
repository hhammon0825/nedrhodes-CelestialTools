Option Strict Off
Option Explicit On
Module Module7
    Public Function Earth_L01(ByRef T As Double) As Double

        ' L0 Segment #1 of 2

        Dim q As Double = 0.0
        'q = 0#
        q = q + 1.75347045673 * System.Math.Cos(0 + 0 * T)
        q = q + 0.03341656456 * System.Math.Cos(4.66925680417 + 6283.0758499914 * T)
        q = q + 0.00034894275 * System.Math.Cos(4.62610241759 + 12566.1516999828 * T)
        q = q + 0.00003497056 * System.Math.Cos(2.74411800971 + 5753.3848848968 * T)
        q = q + 0.00003417571 * System.Math.Cos(2.82886579606 + 3.523118349 * T)
        q = q + 0.00003135896 * System.Math.Cos(3.62767041758 + 77713.7714681205 * T)
        q = q + 0.00002676218 * System.Math.Cos(4.41808351397 + 7860.4193924392 * T)
        q = q + 0.00002342687 * System.Math.Cos(6.13516237631 + 3930.2096962196 * T)
        q = q + 0.00001324292 * System.Math.Cos(0.74246356352 + 11506.7697697936 * T)
        q = q + 0.00001273166 * System.Math.Cos(2.03709655772 + 529.6909650946 * T)
        q = q + 0.00001199167 * System.Math.Cos(1.10962944315 + 1577.3435424478 * T)
        q = q + 0.0000099025 * System.Math.Cos(5.23268129594 + 5884.9268465832 * T)
        q = q + 0.00000901855 * System.Math.Cos(2.04505443513 + 26.2983197998 * T)
        q = q + 0.00000857223 * System.Math.Cos(3.50849156957 + 398.1490034082 * T)
        q = q + 0.00000779786 * System.Math.Cos(1.17882652114 + 5223.6939198022 * T)
        q = q + 0.00000753141 * System.Math.Cos(2.53339053818 + 5507.5532386674 * T)
        q = q + 0.00000505264 * System.Math.Cos(4.58292563052 + 18849.2275499742 * T)
        q = q + 0.00000492379 * System.Math.Cos(4.20506639861 + 775.522611324 * T)
        q = q + 0.00000356655 * System.Math.Cos(2.91954116867 + 0.0673103028 * T)
        q = q + 0.00000317087 * System.Math.Cos(5.84901952218 + 11790.6290886588 * T)
        q = q + 0.00000284125 * System.Math.Cos(1.89869034186 + 796.2980068164 * T)
        q = q + 0.00000271039 * System.Math.Cos(0.31488607649 + 10977.078804699 * T)
        q = q + 0.0000024281 * System.Math.Cos(0.34481140906 + 5486.777843175 * T)
        q = q + 0.0000020616 * System.Math.Cos(4.80646606059 + 2544.3144198834 * T)
        q = q + 0.00000205385 * System.Math.Cos(1.86947813692 + 5573.1428014331 * T)
        q = q + 0.00000202261 * System.Math.Cos(2.45767795458 + 6069.7767545534 * T)
        q = q + 0.00000155516 * System.Math.Cos(0.83306073807 + 213.299095438 * T)
        q = q + 0.00000132212 * System.Math.Cos(3.41118275555 + 2942.4634232916 * T)
        q = q + 0.00000126184 * System.Math.Cos(1.0830263021 + 20.7753954924 * T)
        q = q + 0.00000115132 * System.Math.Cos(0.64544911683 + 0.9803210682 * T)
        q = q + 0.00000102851 * System.Math.Cos(0.63599846727 + 4694.0029547076 * T)
        q = q + 0.00000101895 * System.Math.Cos(0.97569221824 + 15720.8387848784 * T)
        q = q + 0.00000101724 * System.Math.Cos(4.26679821365 + 7.1135470008 * T)
        q = q + 0.00000099206 * System.Math.Cos(6.20992940258 + 2146.1654164752 * T)
        q = q + 0.00000097607 * System.Math.Cos(0.6810127227 + 155.4203994342 * T)
        q = q + 0.00000085803 * System.Math.Cos(5.98322631256 + 161000.685737674 * T)
        q = q + 0.00000085128 * System.Math.Cos(1.29870743025 + 6275.9623029906 * T)
        q = q + 0.00000084711 * System.Math.Cos(3.67080093025 + 71430.6956181291 * T)
        q = q + 0.00000079637 * System.Math.Cos(1.807913307 + 17260.1546546904 * T)
        q = q + 0.00000078756 * System.Math.Cos(3.03698313141 + 12036.4607348882 * T)
        q = q + 0.00000074651 * System.Math.Cos(1.75508916159 + 5088.6288397668 * T)
        q = q + 0.00000073874 * System.Math.Cos(3.50319443167 + 3154.6870848956 * T)
        q = q + 0.00000073547 * System.Math.Cos(4.67926565481 + 801.8209311238 * T)
        q = q + 0.00000069627 * System.Math.Cos(0.83297596966 + 9437.762934887 * T)
        q = q + 0.00000062449 * System.Math.Cos(3.97763880587 + 8827.3902698748 * T)
        q = q + 0.00000061148 * System.Math.Cos(1.81839811024 + 7084.8967811152 * T)
        q = q + 0.00000056963 * System.Math.Cos(2.78430398043 + 6286.5989683404 * T)
        q = q + 0.00000056116 * System.Math.Cos(4.38694880779 + 14143.4952424306 * T)
        q = q + 0.00000055577 * System.Math.Cos(3.47006009062 + 6279.5527316424 * T)
        q = q + 0.00000051992 * System.Math.Cos(0.18914945834 + 12139.5535091068 * T)
        q = q + 0.00000051605 * System.Math.Cos(1.33282746983 + 1748.016413067 * T)
        q = q + 0.00000051145 * System.Math.Cos(0.28306864501 + 5856.4776591154 * T)
        q = q + 0.00000049 * System.Math.Cos(0.48735065033 + 1194.4470102246 * T)
        q = q + 0.00000041036 * System.Math.Cos(5.36817351402 + 8429.2412664666 * T)
        q = q + 0.00000040938 * System.Math.Cos(2.39850881707 + 19651.048481098 * T)
        q = q + 0.000000392 * System.Math.Cos(6.16832995016 + 10447.3878396044 * T)
        q = q + 0.0000003677 * System.Math.Cos(6.04133859347 + 10213.285546211 * T)
        q = q + 0.00000036596 * System.Math.Cos(2.56955238628 + 1059.3819301892 * T)
        q = q + 0.00000035954 * System.Math.Cos(1.70876111898 + 2352.8661537718 * T)
        q = q + 0.00000035566 * System.Math.Cos(1.77597314691 + 6812.766815086 * T)
        q = q + 0.00000033291 * System.Math.Cos(0.59309499459 + 17789.845619785 * T)
        q = q + 0.00000030412 * System.Math.Cos(0.44294464135 + 83996.8473181119 * T)
        q = q + 0.00000030047 * System.Math.Cos(2.73975123935 + 1349.8674096588 * T)
        q = q + 0.00000025352 * System.Math.Cos(3.16470953405 + 4690.4798363586 * T)
        Return (q * 1)
    End Function
    ' ************************

    Public Function Earth_L02(ByRef T As Double) As Double

        ' L0 Segment #2 of 2
        Dim q As Double = 0.0
        'q = 0#
        Return (q * 1)
    End Function
    ' ************************

    Public Function Earth_L11(ByRef T As Double) As Double

        ' L1 Segment #1 of 1
        Dim q As Double = 0.0
        'q = 0#
        q = q + 6283.31966747491 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00206058863 * System.Math.Cos(2.67823455584 + 6283.0758499914 * T)
        q = q + 0.0000430343 * System.Math.Cos(2.63512650414 + 12566.1516999828 * T)
        q = q + 0.00000425264 * System.Math.Cos(1.59046980729 + 3.523118349 * T)
        q = q + 0.00000119261 * System.Math.Cos(5.79557487799 + 26.2983197998 * T)
        q = q + 0.00000108977 * System.Math.Cos(2.96618001993 + 1577.3435424478 * T)
        q = q + 0.00000093478 * System.Math.Cos(2.59212835365 + 18849.2275499742 * T)
        q = q + 0.00000072122 * System.Math.Cos(1.13846158196 + 529.6909650946 * T)
        q = q + 0.00000067768 * System.Math.Cos(1.87472304791 + 398.1490034082 * T)
        q = q + 0.00000067327 * System.Math.Cos(4.40918235168 + 5507.5532386674 * T)
        q = q + 0.00000059027 * System.Math.Cos(2.8879703846 + 5223.6939198022 * T)
        q = q + 0.00000055976 * System.Math.Cos(2.17471680261 + 155.4203994342 * T)
        q = q + 0.00000045407 * System.Math.Cos(0.39803079805 + 796.2980068164 * T)
        q = q + 0.00000036369 * System.Math.Cos(0.46624739835 + 775.522611324 * T)
        q = q + 0.00000028958 * System.Math.Cos(2.64707383882 + 7.1135470008 * T)
        q = q + 0.00000020844 * System.Math.Cos(5.34138275149 + 0.9803210682 * T)
        q = q + 0.00000019097 * System.Math.Cos(1.84628332577 + 5486.777843175 * T)
        q = q + 0.00000018508 * System.Math.Cos(4.96855124577 + 213.299095438 * T)
        q = q + 0.00000017293 * System.Math.Cos(2.99116864949 + 6275.9623029906 * T)
        q = q + 0.00000016233 * System.Math.Cos(0.03216483047 + 2544.3144198834 * T)
        q = q + 0.00000015832 * System.Math.Cos(1.43049285325 + 2146.1654164752 * T)
        q = q + 0.00000014615 * System.Math.Cos(1.20532366323 + 10977.078804699 * T)
        q = q + 0.00000012461 * System.Math.Cos(2.83432285512 + 1748.016413067 * T)
        q = q + 0.00000011877 * System.Math.Cos(3.25804815607 + 5088.6288397668 * T)
        q = q + 0.00000011808 * System.Math.Cos(5.2737979048 + 1194.4470102246 * T)
        q = q + 0.00000011514 * System.Math.Cos(2.07502418155 + 4694.0029547076 * T)
        q = q + 0.00000010641 * System.Math.Cos(0.76614199202 + 553.5694028424 * T)
        q = q + 0.00000009969 * System.Math.Cos(1.30262991097 + 6286.5989683404 * T)
        q = q + 0.00000009721 * System.Math.Cos(4.23925472239 + 1349.8674096588 * T)
        q = q + 0.00000009452 * System.Math.Cos(2.69957062864 + 242.728603974 * T)
        q = q + 0.00000008577 * System.Math.Cos(5.64475868067 + 951.7184062506 * T)
        q = q + 0.00000007576 * System.Math.Cos(5.30062664886 + 2352.8661537718 * T)
        q = q + 0.00000006385 * System.Math.Cos(2.65033984967 + 9437.762934887 * T)
        q = q + 0.00000006101 * System.Math.Cos(4.66632584188 + 4690.4798363586 * T)
        Return (q * T)
    End Function
    Public Function Earth_L21(ByRef T As Double) As Double

        ' L2 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.0005291887 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00008719837 * System.Math.Cos(1.07209665242 + 6283.0758499914 * T)
        q = q + 0.00000309125 * System.Math.Cos(0.86728818832 + 12566.1516999828 * T)
        q = q + 0.00000027339 * System.Math.Cos(0.05297871691 + 3.523118349 * T)
        q = q + 0.00000016334 * System.Math.Cos(5.18826691036 + 26.2983197998 * T)
        q = q + 0.00000015752 * System.Math.Cos(3.6845788943 + 155.4203994342 * T)
        q = q + 0.00000009541 * System.Math.Cos(0.75742297675 + 18849.2275499742 * T)
        q = q + 0.00000008937 * System.Math.Cos(2.05705419118 + 77713.7714681205 * T)
        q = q + 0.00000006952 * System.Math.Cos(0.8267330541 + 775.522611324 * T)
        q = q + 0.00000005064 * System.Math.Cos(4.66284525271 + 1577.3435424478 * T)
        q = q + 0.00000004061 * System.Math.Cos(1.03057162962 + 7.1135470008 * T)
        q = q + 0.0000000381 * System.Math.Cos(3.4405080349 + 5573.1428014331 * T)
        q = q + 0.00000003463 * System.Math.Cos(5.14074632811 + 796.2980068164 * T)
        q = q + 0.00000003169 * System.Math.Cos(6.05291851171 + 5507.5532386674 * T)
        q = q + 0.0000000302 * System.Math.Cos(1.19246506441 + 242.728603974 * T)
        q = q + 0.00000002886 * System.Math.Cos(6.11652627155 + 529.6909650946 * T)
        q = q + 0.00000002714 * System.Math.Cos(0.30637881025 + 398.1490034082 * T)
        q = q + 0.00000002538 * System.Math.Cos(2.27992810679 + 553.5694028424 * T)
        q = q + 0.00000002371 * System.Math.Cos(4.38118838167 + 5223.6939198022 * T)
        q = q + 0.00000002079 * System.Math.Cos(3.75435330484 + 0.9803210682 * T)
        Return (q * T * T)
    End Function
    Public Function Earth_L31(ByRef T As Double) As Double

        ' L3 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00000289226 * System.Math.Cos(5.84384198723 + 6283.0758499914 * T)
        q = q + 0.00000034955 * System.Math.Cos(0 + 0 * T)
        q = q + 0.00000016819 * System.Math.Cos(5.48766912348 + 12566.1516999828 * T)
        q = q + 0.00000002962 * System.Math.Cos(5.19577265202 + 155.4203994342 * T)
        q = q + 0.00000001288 * System.Math.Cos(4.72200252235 + 3.523118349 * T)
        q = q + 0.00000000714 * System.Math.Cos(5.30045809128 + 18849.2275499742 * T)
        q = q + 0.00000000635 * System.Math.Cos(5.96925937141 + 242.728603974 * T)
        Return (q * T * T * T)
    End Function
    Public Function Earth_L41(ByRef T As Double) As Double

        ' L4 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00000114084 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000007717 * System.Math.Cos(4.13446589358 + 6283.0758499914 * T)
        q = q + 0.00000000765 * System.Math.Cos(3.83803776214 + 12566.1516999828 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Earth_L51(ByRef T As Double) As Double

        ' L5 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00000000878 * System.Math.Cos(3.14159265359 + 0 * T)
        Return (q * T * T * T * T * T)
    End Function
    Public Function Earth_B01(ByRef T As Double) As Double

        ' B0 Segment #1 of 1

        Dim q As Double = 0.0

        'q = 0#
        q = q + 0.0000027962 * System.Math.Cos(3.19870156017 + 84334.6615813083 * T)
        q = q + 0.00000101643 * System.Math.Cos(5.42248619256 + 5507.5532386674 * T)
        q = q + 0.00000080445 * System.Math.Cos(3.88013204458 + 5223.6939198022 * T)
        q = q + 0.00000043806 * System.Math.Cos(3.70444689758 + 2352.8661537718 * T)
        q = q + 0.00000031933 * System.Math.Cos(4.00026369781 + 1577.3435424478 * T)
        Return (q * 1)
    End Function
    Public Function Earth_B11(ByRef T As Double) As Double

        ' B1 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.0000000903 * System.Math.Cos(3.8972906189 + 5507.5532386674 * T)
        q = q + 0.00000006177 * System.Math.Cos(1.73038850355 + 5223.6939198022 * T)
        Return (q * T)
    End Function
    Public Function Earth_B21(ByRef T As Double) As Double

        ' B2 Segment #1 of 1
        Dim q As Double = 0.0
        'q = 0#
        Return (q * T * T)
    End Function
    ' ************************

    Public Function Earth_B31(ByRef T As Double) As Double

        ' B3 Segment #1 of 1

        Dim q As Double = 0.0

        'q = 0#
        Return (q * T * T * T)
    End Function
    Public Function Earth_B41(ByRef T As Double) As Double

        ' B4 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        Return (q * T * T * T * T)
    End Function
    Public Function Earth_R01(ByRef T As Double) As Double

        ' R0 Segment #1 of 2

        Dim q As Double = 0.0
        ' = 0#
        q = q + 1.00013988799 * System.Math.Cos(0 + 0 * T)
        q = q + 0.01670699626 * System.Math.Cos(3.09846350771 + 6283.0758499914 * T)
        q = q + 0.00013956023 * System.Math.Cos(3.0552460962 + 12566.1516999828 * T)
        q = q + 0.0000308372 * System.Math.Cos(5.19846674381 + 77713.7714681205 * T)
        q = q + 0.00001628461 * System.Math.Cos(1.17387749012 + 5753.3848848968 * T)
        q = q + 0.00001575568 * System.Math.Cos(2.84685245825 + 7860.4193924392 * T)
        q = q + 0.00000924799 * System.Math.Cos(5.45292234084 + 11506.7697697936 * T)
        q = q + 0.00000542444 * System.Math.Cos(4.56409149777 + 3930.2096962196 * T)
        q = q + 0.0000047211 * System.Math.Cos(3.66100022149 + 5884.9268465832 * T)
        q = q + 0.00000345983 * System.Math.Cos(0.96368617687 + 5507.5532386674 * T)
        q = q + 0.0000032878 * System.Math.Cos(5.89983646482 + 5223.6939198022 * T)
        q = q + 0.00000306784 * System.Math.Cos(0.29867139512 + 5573.1428014331 * T)
        q = q + 0.00000243189 * System.Math.Cos(4.27349536153 + 11790.6290886588 * T)
        q = q + 0.00000211829 * System.Math.Cos(5.84714540314 + 1577.3435424478 * T)
        q = q + 0.00000185752 * System.Math.Cos(5.02194447178 + 10977.078804699 * T)
        q = q + 0.00000174844 * System.Math.Cos(3.01193636534 + 18849.2275499742 * T)
        q = q + 0.00000109835 * System.Math.Cos(5.05510636285 + 5486.777843175 * T)
        q = q + 0.00000098316 * System.Math.Cos(0.88681311277 + 6069.7767545534 * T)
        q = q + 0.00000086499 * System.Math.Cos(5.68959778254 + 15720.8387848784 * T)
        q = q + 0.00000085825 * System.Math.Cos(1.27083733351 + 161000.685737674 * T)
        q = q + 0.00000064903 * System.Math.Cos(0.27250613787 + 17260.1546546904 * T)
        q = q + 0.00000062916 * System.Math.Cos(0.92177108832 + 529.6909650946 * T)
        q = q + 0.00000057056 * System.Math.Cos(2.01374292014 + 83996.8473181119 * T)
        q = q + 0.00000055736 * System.Math.Cos(5.24159798933 + 71430.6956181291 * T)
        q = q + 0.00000049384 * System.Math.Cos(3.24501240359 + 2544.3144198834 * T)
        q = q + 0.00000046963 * System.Math.Cos(2.57805070386 + 775.522611324 * T)
        q = q + 0.00000044661 * System.Math.Cos(5.53715807302 + 9437.762934887 * T)
        q = q + 0.00000042515 * System.Math.Cos(6.01110242003 + 6275.9623029906 * T)
        q = q + 0.00000038968 * System.Math.Cos(5.36071738169 + 4694.0029547076 * T)
        q = q + 0.00000038245 * System.Math.Cos(2.39255343974 + 8827.3902698748 * T)
        q = q + 0.0000003749 * System.Math.Cos(0.82952922332 + 19651.048481098 * T)
        q = q + 0.00000036957 * System.Math.Cos(4.90107591914 + 12139.5535091068 * T)
        q = q + 0.0000003566 * System.Math.Cos(1.67468058995 + 12036.4607348882 * T)
        q = q + 0.00000034537 * System.Math.Cos(1.84270693282 + 2942.4634232916 * T)
        q = q + 0.00000033193 * System.Math.Cos(0.24370300098 + 7084.8967811152 * T)
        q = q + 0.00000031921 * System.Math.Cos(0.18368229781 + 5088.6288397668 * T)
        q = q + 0.00000031846 * System.Math.Cos(1.77775642085 + 398.1490034082 * T)
        q = q + 0.00000028464 * System.Math.Cos(1.21344868176 + 6286.5989683404 * T)
        q = q + 0.00000027793 * System.Math.Cos(1.89934330904 + 6279.5527316424 * T)
        q = q + 0.00000026275 * System.Math.Cos(4.58896850401 + 10447.3878396044 * T)
        Return (q * 1)
    End Function
    Public Function Earth_R02(ByRef T As Double) As Double

        ' R0 Segment #2 of 2

        Dim q As Double = 0.0
        'q = 0#
        Return (q * 1)
    End Function
    Public Function Earth_R11(ByRef T As Double) As Double

        ' R1 Segment #1 of 1

        Dim q As Double = 0.0

        'q = 0#
        q = q + 0.00103018608 * System.Math.Cos(1.10748969588 + 6283.0758499914 * T)
        q = q + 0.00001721238 * System.Math.Cos(1.06442301418 + 12566.1516999828 * T)
        q = q + 0.00000702215 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000032346 * System.Math.Cos(1.02169059149 + 18849.2275499742 * T)
        q = q + 0.00000030799 * System.Math.Cos(2.84353804832 + 5507.5532386674 * T)
        q = q + 0.00000024971 * System.Math.Cos(1.31906709482 + 5223.6939198022 * T)
        q = q + 0.00000018485 * System.Math.Cos(1.42429748614 + 1577.3435424478 * T)
        q = q + 0.00000010078 * System.Math.Cos(5.91378194648 + 10977.078804699 * T)
        q = q + 0.00000008654 * System.Math.Cos(1.42046854427 + 6275.9623029906 * T)
        q = q + 0.00000008634 * System.Math.Cos(0.27146150602 + 5486.777843175 * T)
        Return (q * T)
    End Function
    Public Function Earth_R21(ByRef T As Double) As Double

        ' R2 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00004359385 * System.Math.Cos(5.78455133738 + 6283.0758499914 * T)
        q = q + 0.00000123633 * System.Math.Cos(5.57934722157 + 12566.1516999828 * T)
        q = q + 0.00000012341 * System.Math.Cos(3.14159265359 + 0 * T)
        q = q + 0.00000008792 * System.Math.Cos(3.62777733395 + 77713.7714681205 * T)
        q = q + 0.00000005689 * System.Math.Cos(1.86958905084 + 5573.1428014331 * T)
        q = q + 0.00000003301 * System.Math.Cos(5.47027913302 + 18849.2275499742 * T)
        Return (q * T * T)
    End Function
    Public Function Earth_R31(ByRef T As Double) As Double

        ' R3 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00000144595 * System.Math.Cos(4.27319435148 + 6283.0758499914 * T)
        q = q + 0.00000006729 * System.Math.Cos(3.91697608662 + 12566.1516999828 * T)
        Return (q * T * T * T)
    End Function
    Public Function Earth_R41(ByRef T As Double) As Double

        ' R4 Segment #1 of 1

        Dim q As Double = 0.0
        'q = 0#
        q = q + 0.00000003858 * System.Math.Cos(2.56384387339 + 6283.0758499914 * T)
        Return (q * T * T * T * T)
    End Function
    Public Function Earth_R51(ByRef T As Double) As Double

        ' R5 Segment #1 of 1
        Dim q As Double = 0.0
        'q = 0#
        Return (q * T * T * T * T * T)
    End Function
End Module