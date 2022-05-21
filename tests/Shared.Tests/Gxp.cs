namespace Shared.Tests;

public static class Gxp
{
    public static string FileAsString()
    {
        const string gxp = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<gpx xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns=""http://www.topografix.com/GPX/1/1"" xmlns:gpxdata=""http://www.cluetrust.com/XML/GPXDATA/1/0"" xsi:schemaLocation=""http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd http://www.cluetrust.com/XML/GPXDATA/1/0 http://www.cluetrust.com/Schemas/gpxdata10.xsd"" version=""1.1"" creator=""http://ridewithgps.com/"">
  <metadata>
    <name></name>
    <link href=""https://ridewithgps.com/routes/27445824"">
      <text></text>
    </link>
    <time></time>
  </metadata>
  <trk>
    <name></name>
    <trkseg>
      <trkpt lat=""59.86389"" lon=""17.62482"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.8644"" lon=""17.62391"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.86442"" lon=""17.62388"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.86442"" lon=""17.62388"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.86381"" lon=""17.62253"">
        <ele>18.0</ele>
      </trkpt>
      <trkpt lat=""59.86308"" lon=""17.62087"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.86241"" lon=""17.61938"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.86219"" lon=""17.6189"">
        <ele>19.6</ele>
      </trkpt>
      <trkpt lat=""59.86172"" lon=""17.61784"">
        <ele>19.0</ele>
      </trkpt>
      <trkpt lat=""59.86147"" lon=""17.61729"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.8614"" lon=""17.61712"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.86101"" lon=""17.61625"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.86072"" lon=""17.61561"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.86035"" lon=""17.61489"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.86022"" lon=""17.61464"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.85967"" lon=""17.6136"">
        <ele>21.4</ele>
      </trkpt>
      <trkpt lat=""59.85956"" lon=""17.6133099"">
        <ele>21.5</ele>
      </trkpt>
      <trkpt lat=""59.85943"" lon=""17.61291"">
        <ele>21.5</ele>
      </trkpt>
      <trkpt lat=""59.85915"" lon=""17.6120899"">
        <ele>22.0</ele>
      </trkpt>
      <trkpt lat=""59.85897"" lon=""17.61156"">
        <ele>22.1</ele>
      </trkpt>
      <trkpt lat=""59.85883"" lon=""17.61114"">
        <ele>22.6</ele>
      </trkpt>
      <trkpt lat=""59.85879"" lon=""17.61103"">
        <ele>22.8</ele>
      </trkpt>
      <trkpt lat=""59.85863"" lon=""17.61056"">
        <ele>23.2</ele>
      </trkpt>
      <trkpt lat=""59.85863"" lon=""17.61056"">
        <ele>23.2</ele>
      </trkpt>
      <trkpt lat=""59.85826"" lon=""17.6109699"">
        <ele>23.0</ele>
      </trkpt>
      <trkpt lat=""59.85804"" lon=""17.61124"">
        <ele>23.2</ele>
      </trkpt>
      <trkpt lat=""59.85798"" lon=""17.61132"">
        <ele>23.3</ele>
      </trkpt>
      <trkpt lat=""59.85788"" lon=""17.61144"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.8578"" lon=""17.61154"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.85774"" lon=""17.61161"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.85731"" lon=""17.61218"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.85724"" lon=""17.61226"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.8572"" lon=""17.61232"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.85715"" lon=""17.61238"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.85679"" lon=""17.6128"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.85628"" lon=""17.61339"">
        <ele>24.5</ele>
      </trkpt>
      <trkpt lat=""59.85616"" lon=""17.61353"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.85545"" lon=""17.61436"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85545"" lon=""17.61436"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85544"" lon=""17.61434"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85544"" lon=""17.61432"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85543"" lon=""17.61431"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85543"" lon=""17.61429"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85542"" lon=""17.61428"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85541"" lon=""17.61427"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.8554"" lon=""17.61426"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85539"" lon=""17.6142499"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85538"" lon=""17.6142499"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85537"" lon=""17.61424"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85536"" lon=""17.61424"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85535"" lon=""17.61424"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85534"" lon=""17.61424"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85533"" lon=""17.6142499"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85532"" lon=""17.6142499"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85531"" lon=""17.61426"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.8553"" lon=""17.61427"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85529"" lon=""17.61428"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85528"" lon=""17.61429"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.85528"" lon=""17.61431"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85527"" lon=""17.61432"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85526"" lon=""17.61434"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85526"" lon=""17.61436"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.85526"" lon=""17.61438"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.85525"" lon=""17.61439"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.85525"" lon=""17.61441"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.85525"" lon=""17.61443"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.85525"" lon=""17.61445"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.85525"" lon=""17.61447"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.85525"" lon=""17.61449"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.85525"" lon=""17.61451"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.85526"" lon=""17.6145299"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.85526"" lon=""17.61456"">
        <ele>24.5</ele>
      </trkpt>
      <trkpt lat=""59.85494"" lon=""17.6149"">
        <ele>24.9</ele>
      </trkpt>
      <trkpt lat=""59.85485"" lon=""17.6149999"">
        <ele>25.0</ele>
      </trkpt>
      <trkpt lat=""59.85457"" lon=""17.61531"">
        <ele>25.2</ele>
      </trkpt>
      <trkpt lat=""59.85417"" lon=""17.61579"">
        <ele>25.0</ele>
      </trkpt>
      <trkpt lat=""59.85389"" lon=""17.61612"">
        <ele>25.3</ele>
      </trkpt>
      <trkpt lat=""59.85359"" lon=""17.61642"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.85358"" lon=""17.6164"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.85358"" lon=""17.61638"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.85356"" lon=""17.61636"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85355"" lon=""17.61634"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85354"" lon=""17.61633"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85352"" lon=""17.61632"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85351"" lon=""17.61631"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.8535"" lon=""17.61631"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85348"" lon=""17.6163"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85347"" lon=""17.61631"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85345"" lon=""17.61631"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85344"" lon=""17.61632"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85342"" lon=""17.61633"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85341"" lon=""17.61635"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.8534"" lon=""17.61637"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.85338"" lon=""17.6164099"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.85337"" lon=""17.61643"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.85337"" lon=""17.61646"">
        <ele>25.8</ele>
      </trkpt>
      <trkpt lat=""59.85336"" lon=""17.61649"">
        <ele>25.8</ele>
      </trkpt>
      <trkpt lat=""59.85336"" lon=""17.61651"">
        <ele>25.8</ele>
      </trkpt>
      <trkpt lat=""59.85336"" lon=""17.61654"">
        <ele>25.8</ele>
      </trkpt>
      <trkpt lat=""59.85336"" lon=""17.61657"">
        <ele>25.9</ele>
      </trkpt>
      <trkpt lat=""59.85336"" lon=""17.6165999"">
        <ele>25.9</ele>
      </trkpt>
      <trkpt lat=""59.85336"" lon=""17.61663"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.85337"" lon=""17.61666"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.85338"" lon=""17.6167"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.85321"" lon=""17.61687"">
        <ele>25.9</ele>
      </trkpt>
      <trkpt lat=""59.85284"" lon=""17.61719"">
        <ele>25.4</ele>
      </trkpt>
      <trkpt lat=""59.85259"" lon=""17.61741"">
        <ele>25.1</ele>
      </trkpt>
      <trkpt lat=""59.85197"" lon=""17.61795"">
        <ele>25.8</ele>
      </trkpt>
      <trkpt lat=""59.85114"" lon=""17.61868"">
        <ele>26.6</ele>
      </trkpt>
      <trkpt lat=""59.85107"" lon=""17.61873"">
        <ele>26.7</ele>
      </trkpt>
      <trkpt lat=""59.85097"" lon=""17.61881"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.85081"" lon=""17.61909"">
        <ele>27.1</ele>
      </trkpt>
      <trkpt lat=""59.85078"" lon=""17.61915"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.85029"" lon=""17.6201"">
        <ele>29.5</ele>
      </trkpt>
      <trkpt lat=""59.85005"" lon=""17.62055"">
        <ele>30.1</ele>
      </trkpt>
      <trkpt lat=""59.84995"" lon=""17.6207299"">
        <ele>30.2</ele>
      </trkpt>
      <trkpt lat=""59.84992"" lon=""17.62078"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.84988"" lon=""17.62083"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.84986"" lon=""17.62087"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.84981"" lon=""17.62091"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.84981"" lon=""17.62091"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.84949"" lon=""17.6212"">
        <ele>30.8</ele>
      </trkpt>
      <trkpt lat=""59.84888"" lon=""17.62177"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.84876"" lon=""17.62189"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.84813"" lon=""17.62248"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.84794"" lon=""17.62266"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.84754"" lon=""17.62304"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.84721"" lon=""17.62337"">
        <ele>37.1</ele>
      </trkpt>
      <trkpt lat=""59.84706"" lon=""17.62356"">
        <ele>38.2</ele>
      </trkpt>
      <trkpt lat=""59.84694"" lon=""17.6237299"">
        <ele>38.8</ele>
      </trkpt>
      <trkpt lat=""59.84694"" lon=""17.6237299"">
        <ele>38.8</ele>
      </trkpt>
      <trkpt lat=""59.84682"" lon=""17.62396"">
        <ele>38.9</ele>
      </trkpt>
      <trkpt lat=""59.84673"" lon=""17.62422"">
        <ele>38.3</ele>
      </trkpt>
      <trkpt lat=""59.84666"" lon=""17.6244799"">
        <ele>37.1</ele>
      </trkpt>
      <trkpt lat=""59.84666"" lon=""17.6244799"">
        <ele>37.1</ele>
      </trkpt>
      <trkpt lat=""59.84654"" lon=""17.62493"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.8465"" lon=""17.62513"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.84646"" lon=""17.62539"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.84643"" lon=""17.62562"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.84643"" lon=""17.62562"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.84643"" lon=""17.62566"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.84633"" lon=""17.6264499"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.8463"" lon=""17.62661"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.84621"" lon=""17.62756"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.84619"" lon=""17.62772"">
        <ele>32.9</ele>
      </trkpt>
      <trkpt lat=""59.84618"" lon=""17.62787"">
        <ele>32.5</ele>
      </trkpt>
      <trkpt lat=""59.84613"" lon=""17.6286999"">
        <ele>30.9</ele>
      </trkpt>
      <trkpt lat=""59.84607"" lon=""17.62957"">
        <ele>29.7</ele>
      </trkpt>
      <trkpt lat=""59.84604"" lon=""17.62997"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84603"" lon=""17.63016"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84602"" lon=""17.63025"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84601"" lon=""17.63033"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84601"" lon=""17.63033"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.846"" lon=""17.63033"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84599"" lon=""17.63033"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84598"" lon=""17.63033"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84597"" lon=""17.63034"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84596"" lon=""17.63034"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84595"" lon=""17.63035"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84595"" lon=""17.63036"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84594"" lon=""17.63036"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84594"" lon=""17.63037"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84593"" lon=""17.63038"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84593"" lon=""17.6303899"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84592"" lon=""17.6304"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84592"" lon=""17.63041"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63042"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63043"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63045"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63046"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63047"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63048"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63049"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63051"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63052"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63053"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63054"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63055"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84591"" lon=""17.63057"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84592"" lon=""17.6305799"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.84546"" lon=""17.63128"">
        <ele>30.0</ele>
      </trkpt>
      <trkpt lat=""59.84528"" lon=""17.63155"">
        <ele>30.0</ele>
      </trkpt>
      <trkpt lat=""59.84464"" lon=""17.63253"">
        <ele>31.3</ele>
      </trkpt>
      <trkpt lat=""59.84457"" lon=""17.63263"">
        <ele>31.6</ele>
      </trkpt>
      <trkpt lat=""59.84457"" lon=""17.63264"">
        <ele>31.6</ele>
      </trkpt>
      <trkpt lat=""59.84448"" lon=""17.63277"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.84448"" lon=""17.63277"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.84445"" lon=""17.63269"">
        <ele>32.1</ele>
      </trkpt>
      <trkpt lat=""59.84445"" lon=""17.63269"">
        <ele>32.1</ele>
      </trkpt>
      <trkpt lat=""59.84434"" lon=""17.63292"">
        <ele>32.5</ele>
      </trkpt>
      <trkpt lat=""59.84423"" lon=""17.63308"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.84407"" lon=""17.63325"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.84406"" lon=""17.63326"">
        <ele>32.6</ele>
      </trkpt>
      <trkpt lat=""59.84386"" lon=""17.63347"">
        <ele>31.9</ele>
      </trkpt>
      <trkpt lat=""59.84371"" lon=""17.63364"">
        <ele>31.4</ele>
      </trkpt>
      <trkpt lat=""59.84361"" lon=""17.63381"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.84345"" lon=""17.63414"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.84342"" lon=""17.63425"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.84342"" lon=""17.6342399"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.84333"" lon=""17.63446"">
        <ele>30.0</ele>
      </trkpt>
      <trkpt lat=""59.84326"" lon=""17.63465"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.84307"" lon=""17.63522"">
        <ele>31.3</ele>
      </trkpt>
      <trkpt lat=""59.84294"" lon=""17.63568"">
        <ele>32.3</ele>
      </trkpt>
      <trkpt lat=""59.84289"" lon=""17.63582"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.84285"" lon=""17.63592"">
        <ele>33.0</ele>
      </trkpt>
      <trkpt lat=""59.84282"" lon=""17.63596"">
        <ele>33.2</ele>
      </trkpt>
      <trkpt lat=""59.84273"" lon=""17.63603"">
        <ele>33.8</ele>
      </trkpt>
      <trkpt lat=""59.84273"" lon=""17.63603"">
        <ele>33.8</ele>
      </trkpt>
      <trkpt lat=""59.8428"" lon=""17.63672"">
        <ele>33.9</ele>
      </trkpt>
      <trkpt lat=""59.84288"" lon=""17.63753"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.84289"" lon=""17.63768"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.84289"" lon=""17.63768"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.84282"" lon=""17.6377099"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.84282"" lon=""17.6377099"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.84281"" lon=""17.63783"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.84277"" lon=""17.63797"">
        <ele>34.7</ele>
      </trkpt>
      <trkpt lat=""59.84273"" lon=""17.63803"">
        <ele>34.8</ele>
      </trkpt>
      <trkpt lat=""59.84241"" lon=""17.63819"">
        <ele>35.6</ele>
      </trkpt>
      <trkpt lat=""59.84226"" lon=""17.63827"">
        <ele>36.2</ele>
      </trkpt>
      <trkpt lat=""59.84216"" lon=""17.63833"">
        <ele>36.6</ele>
      </trkpt>
      <trkpt lat=""59.84216"" lon=""17.63833"">
        <ele>36.6</ele>
      </trkpt>
      <trkpt lat=""59.84212"" lon=""17.63849"">
        <ele>37.0</ele>
      </trkpt>
      <trkpt lat=""59.8421"" lon=""17.63861"">
        <ele>37.3</ele>
      </trkpt>
      <trkpt lat=""59.84207"" lon=""17.63875"">
        <ele>37.5</ele>
      </trkpt>
      <trkpt lat=""59.84207"" lon=""17.63875"">
        <ele>37.5</ele>
      </trkpt>
      <trkpt lat=""59.8421"" lon=""17.63885"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.8421"" lon=""17.63889"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.84212"" lon=""17.63907"">
        <ele>37.8</ele>
      </trkpt>
      <trkpt lat=""59.84213"" lon=""17.6392"">
        <ele>37.9</ele>
      </trkpt>
      <trkpt lat=""59.84213"" lon=""17.63947"">
        <ele>38.5</ele>
      </trkpt>
      <trkpt lat=""59.84209"" lon=""17.6397"">
        <ele>38.9</ele>
      </trkpt>
      <trkpt lat=""59.84207"" lon=""17.63992"">
        <ele>39.4</ele>
      </trkpt>
      <trkpt lat=""59.84209"" lon=""17.64009"">
        <ele>39.5</ele>
      </trkpt>
      <trkpt lat=""59.84211"" lon=""17.64025"">
        <ele>39.5</ele>
      </trkpt>
      <trkpt lat=""59.84219"" lon=""17.64056"">
        <ele>39.4</ele>
      </trkpt>
      <trkpt lat=""59.84224"" lon=""17.64085"">
        <ele>39.3</ele>
      </trkpt>
      <trkpt lat=""59.84224"" lon=""17.6410899"">
        <ele>39.2</ele>
      </trkpt>
      <trkpt lat=""59.8422"" lon=""17.64135"">
        <ele>39.2</ele>
      </trkpt>
      <trkpt lat=""59.84213"" lon=""17.64178"">
        <ele>39.2</ele>
      </trkpt>
      <trkpt lat=""59.84202"" lon=""17.64226"">
        <ele>39.0</ele>
      </trkpt>
      <trkpt lat=""59.84202"" lon=""17.64228"">
        <ele>39.0</ele>
      </trkpt>
      <trkpt lat=""59.84199"" lon=""17.64252"">
        <ele>38.8</ele>
      </trkpt>
      <trkpt lat=""59.842"" lon=""17.6427"">
        <ele>38.5</ele>
      </trkpt>
      <trkpt lat=""59.84202"" lon=""17.64315"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.84204"" lon=""17.6434"">
        <ele>37.2</ele>
      </trkpt>
      <trkpt lat=""59.84206"" lon=""17.64361"">
        <ele>36.9</ele>
      </trkpt>
      <trkpt lat=""59.84207"" lon=""17.64386"">
        <ele>36.7</ele>
      </trkpt>
      <trkpt lat=""59.84201"" lon=""17.64437"">
        <ele>36.6</ele>
      </trkpt>
      <trkpt lat=""59.84201"" lon=""17.64437"">
        <ele>36.6</ele>
      </trkpt>
      <trkpt lat=""59.842"" lon=""17.64438"">
        <ele>36.6</ele>
      </trkpt>
      <trkpt lat=""59.8419"" lon=""17.6446599"">
        <ele>36.7</ele>
      </trkpt>
      <trkpt lat=""59.84168"" lon=""17.64524"">
        <ele>37.0</ele>
      </trkpt>
      <trkpt lat=""59.84162"" lon=""17.64543"">
        <ele>36.9</ele>
      </trkpt>
      <trkpt lat=""59.8416"" lon=""17.64551"">
        <ele>36.8</ele>
      </trkpt>
      <trkpt lat=""59.84101"" lon=""17.64707"">
        <ele>33.9</ele>
      </trkpt>
      <trkpt lat=""59.84101"" lon=""17.64707"">
        <ele>33.9</ele>
      </trkpt>
      <trkpt lat=""59.84091"" lon=""17.64734"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.84084"" lon=""17.64736"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.84084"" lon=""17.64736"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.84084"" lon=""17.64733"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.84084"" lon=""17.64729"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.84084"" lon=""17.64726"">
        <ele>33.9</ele>
      </trkpt>
      <trkpt lat=""59.84083"" lon=""17.64723"">
        <ele>33.7</ele>
      </trkpt>
      <trkpt lat=""59.84082"" lon=""17.6472"">
        <ele>33.5</ele>
      </trkpt>
      <trkpt lat=""59.84081"" lon=""17.64718"">
        <ele>33.4</ele>
      </trkpt>
      <trkpt lat=""59.8408"" lon=""17.64715"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.84079"" lon=""17.64713"">
        <ele>33.1</ele>
      </trkpt>
      <trkpt lat=""59.84078"" lon=""17.64711"">
        <ele>33.0</ele>
      </trkpt>
      <trkpt lat=""59.84077"" lon=""17.6470999"">
        <ele>33.0</ele>
      </trkpt>
      <trkpt lat=""59.84075"" lon=""17.64708"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.84074"" lon=""17.64707"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.84072"" lon=""17.64707"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.8407"" lon=""17.64707"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.84069"" lon=""17.64707"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.84067"" lon=""17.64708"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.84066"" lon=""17.64709"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.84064"" lon=""17.6470999"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.84063"" lon=""17.64712"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.84062"" lon=""17.64714"">
        <ele>32.9</ele>
      </trkpt>
      <trkpt lat=""59.8406"" lon=""17.64716"">
        <ele>33.0</ele>
      </trkpt>
      <trkpt lat=""59.84059"" lon=""17.6471899"">
        <ele>33.1</ele>
      </trkpt>
      <trkpt lat=""59.84058"" lon=""17.64721"">
        <ele>33.2</ele>
      </trkpt>
      <trkpt lat=""59.84058"" lon=""17.64724"">
        <ele>33.4</ele>
      </trkpt>
      <trkpt lat=""59.84057"" lon=""17.64728"">
        <ele>33.5</ele>
      </trkpt>
      <trkpt lat=""59.84057"" lon=""17.64731"">
        <ele>33.7</ele>
      </trkpt>
      <trkpt lat=""59.84056"" lon=""17.64734"">
        <ele>33.8</ele>
      </trkpt>
      <trkpt lat=""59.84056"" lon=""17.6473799"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.84057"" lon=""17.64741"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.84057"" lon=""17.64746"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.84014"" lon=""17.64772"">
        <ele>35.7</ele>
      </trkpt>
      <trkpt lat=""59.8398"" lon=""17.64791"">
        <ele>37.0</ele>
      </trkpt>
      <trkpt lat=""59.83974"" lon=""17.64797"">
        <ele>37.3</ele>
      </trkpt>
      <trkpt lat=""59.83971"" lon=""17.64802"">
        <ele>37.5</ele>
      </trkpt>
      <trkpt lat=""59.83968"" lon=""17.64808"">
        <ele>37.7</ele>
      </trkpt>
      <trkpt lat=""59.83958"" lon=""17.64838"">
        <ele>38.5</ele>
      </trkpt>
      <trkpt lat=""59.83947"" lon=""17.6487"">
        <ele>37.8</ele>
      </trkpt>
      <trkpt lat=""59.83946"" lon=""17.64881"">
        <ele>37.7</ele>
      </trkpt>
      <trkpt lat=""59.83946"" lon=""17.64891"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.83947"" lon=""17.64901"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.83949"" lon=""17.6492"">
        <ele>37.5</ele>
      </trkpt>
      <trkpt lat=""59.83949"" lon=""17.64928"">
        <ele>37.4</ele>
      </trkpt>
      <trkpt lat=""59.83957"" lon=""17.65015"">
        <ele>36.7</ele>
      </trkpt>
      <trkpt lat=""59.83957"" lon=""17.65032"">
        <ele>36.4</ele>
      </trkpt>
      <trkpt lat=""59.83955"" lon=""17.65046"">
        <ele>36.1</ele>
      </trkpt>
      <trkpt lat=""59.83953"" lon=""17.65052"">
        <ele>35.9</ele>
      </trkpt>
      <trkpt lat=""59.8395"" lon=""17.65061"">
        <ele>35.7</ele>
      </trkpt>
      <trkpt lat=""59.83949"" lon=""17.65064"">
        <ele>35.7</ele>
      </trkpt>
      <trkpt lat=""59.83941"" lon=""17.65087"">
        <ele>35.2</ele>
      </trkpt>
      <trkpt lat=""59.83941"" lon=""17.65086"">
        <ele>35.2</ele>
      </trkpt>
      <trkpt lat=""59.83938"" lon=""17.65095"">
        <ele>35.0</ele>
      </trkpt>
      <trkpt lat=""59.83932"" lon=""17.65108"">
        <ele>34.8</ele>
      </trkpt>
      <trkpt lat=""59.83932"" lon=""17.65109"">
        <ele>34.8</ele>
      </trkpt>
      <trkpt lat=""59.8393"" lon=""17.65116"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.83927"" lon=""17.65121"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.8392"" lon=""17.65139"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.83916"" lon=""17.65143"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.83912"" lon=""17.65145"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.83909"" lon=""17.65146"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.83907"" lon=""17.65146"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.83904"" lon=""17.65146"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.839"" lon=""17.65144"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.83891"" lon=""17.65138"">
        <ele>34.2</ele>
      </trkpt>
      <trkpt lat=""59.83852"" lon=""17.65112"">
        <ele>34.1</ele>
      </trkpt>
      <trkpt lat=""59.83848"" lon=""17.65108"">
        <ele>34.1</ele>
      </trkpt>
      <trkpt lat=""59.83846"" lon=""17.65106"">
        <ele>34.1</ele>
      </trkpt>
      <trkpt lat=""59.83848"" lon=""17.65108"">
        <ele>34.1</ele>
      </trkpt>
      <trkpt lat=""59.83848"" lon=""17.65108"">
        <ele>34.1</ele>
      </trkpt>
      <trkpt lat=""59.83859"" lon=""17.65082"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.83859"" lon=""17.65082"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.83873"" lon=""17.65092"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.83895"" lon=""17.65106"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.83896"" lon=""17.65106"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.83896"" lon=""17.65107"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.83918"" lon=""17.65116"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.83927"" lon=""17.65121"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.83951"" lon=""17.65135"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.83957"" lon=""17.65142"">
        <ele>34.1</ele>
      </trkpt>
      <trkpt lat=""59.84003"" lon=""17.6519"">
        <ele>31.9</ele>
      </trkpt>
      <trkpt lat=""59.84046"" lon=""17.65246"">
        <ele>28.7</ele>
      </trkpt>
      <trkpt lat=""59.84084"" lon=""17.65306"">
        <ele>24.6</ele>
      </trkpt>
      <trkpt lat=""59.84096"" lon=""17.65331"">
        <ele>22.5</ele>
      </trkpt>
      <trkpt lat=""59.84097"" lon=""17.65334"">
        <ele>22.3</ele>
      </trkpt>
      <trkpt lat=""59.84106"" lon=""17.65361"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.84113"" lon=""17.65378"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.84133"" lon=""17.65448"">
        <ele>14.9</ele>
      </trkpt>
      <trkpt lat=""59.84161"" lon=""17.6556399"">
        <ele>10.3</ele>
      </trkpt>
      <trkpt lat=""59.84167"" lon=""17.6559199"">
        <ele>9.9</ele>
      </trkpt>
      <trkpt lat=""59.84173"" lon=""17.6561999"">
        <ele>9.6</ele>
      </trkpt>
      <trkpt lat=""59.84179"" lon=""17.65642"">
        <ele>9.4</ele>
      </trkpt>
      <trkpt lat=""59.84184"" lon=""17.65664"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.84188"" lon=""17.65681"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.84192"" lon=""17.657"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.84197"" lon=""17.65721"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.84202"" lon=""17.65744"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.8422"" lon=""17.65823"">
        <ele>8.4</ele>
      </trkpt>
      <trkpt lat=""59.8423"" lon=""17.65862"">
        <ele>8.2</ele>
      </trkpt>
      <trkpt lat=""59.84253"" lon=""17.65979"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.8426"" lon=""17.66006"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.84265"" lon=""17.66029"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.8429"" lon=""17.66123"">
        <ele>7.7</ele>
      </trkpt>
      <trkpt lat=""59.84334"" lon=""17.6627699"">
        <ele>10.6</ele>
      </trkpt>
      <trkpt lat=""59.84384"" lon=""17.66431"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.84437"" lon=""17.66599"">
        <ele>9.9</ele>
      </trkpt>
      <trkpt lat=""59.84483"" lon=""17.66738"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.84485"" lon=""17.66744"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.84489"" lon=""17.66761"">
        <ele>8.8</ele>
      </trkpt>
      <trkpt lat=""59.84495"" lon=""17.66788"">
        <ele>8.1</ele>
      </trkpt>
      <trkpt lat=""59.84502"" lon=""17.6682099"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.84508"" lon=""17.66855"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.84512"" lon=""17.66888"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.84512"" lon=""17.66914"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.84511"" lon=""17.6692399"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.84511"" lon=""17.6692399"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.84514"" lon=""17.66929"">
        <ele>7.4</ele>
      </trkpt>
      <trkpt lat=""59.84519"" lon=""17.66941"">
        <ele>7.6</ele>
      </trkpt>
      <trkpt lat=""59.84522"" lon=""17.66951"">
        <ele>7.7</ele>
      </trkpt>
      <trkpt lat=""59.84524"" lon=""17.66963"">
        <ele>7.8</ele>
      </trkpt>
      <trkpt lat=""59.84534"" lon=""17.67047"">
        <ele>8.2</ele>
      </trkpt>
      <trkpt lat=""59.84536"" lon=""17.67082"">
        <ele>8.4</ele>
      </trkpt>
      <trkpt lat=""59.84536"" lon=""17.67083"">
        <ele>8.4</ele>
      </trkpt>
      <trkpt lat=""59.84538"" lon=""17.67109"">
        <ele>8.7</ele>
      </trkpt>
      <trkpt lat=""59.84541"" lon=""17.67169"">
        <ele>9.5</ele>
      </trkpt>
      <trkpt lat=""59.84543"" lon=""17.6724"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.84543"" lon=""17.67318"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.84541"" lon=""17.67376"">
        <ele>12.5</ele>
      </trkpt>
      <trkpt lat=""59.84539"" lon=""17.67428"">
        <ele>12.5</ele>
      </trkpt>
      <trkpt lat=""59.84536"" lon=""17.67474"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.84527"" lon=""17.67541"">
        <ele>11.6</ele>
      </trkpt>
      <trkpt lat=""59.84524"" lon=""17.67569"">
        <ele>11.3</ele>
      </trkpt>
      <trkpt lat=""59.84524"" lon=""17.67577"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.84525"" lon=""17.67586"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.84528"" lon=""17.67602"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.84528"" lon=""17.67657"">
        <ele>10.8</ele>
      </trkpt>
      <trkpt lat=""59.84528"" lon=""17.6769"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.84527"" lon=""17.67708"">
        <ele>10.6</ele>
      </trkpt>
      <trkpt lat=""59.84523"" lon=""17.67748"">
        <ele>10.4</ele>
      </trkpt>
      <trkpt lat=""59.84506"" lon=""17.67865"">
        <ele>10.3</ele>
      </trkpt>
      <trkpt lat=""59.84473"" lon=""17.6808799"">
        <ele>13.4</ele>
      </trkpt>
      <trkpt lat=""59.84458"" lon=""17.6818199"">
        <ele>12.5</ele>
      </trkpt>
      <trkpt lat=""59.84439"" lon=""17.68308"">
        <ele>11.1</ele>
      </trkpt>
      <trkpt lat=""59.84419"" lon=""17.68437"">
        <ele>9.8</ele>
      </trkpt>
      <trkpt lat=""59.84383"" lon=""17.68666"">
        <ele>11.6</ele>
      </trkpt>
      <trkpt lat=""59.84383"" lon=""17.6866999"">
        <ele>11.6</ele>
      </trkpt>
      <trkpt lat=""59.84357"" lon=""17.68842"">
        <ele>13.6</ele>
      </trkpt>
      <trkpt lat=""59.84355"" lon=""17.68847"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.84349"" lon=""17.68857"">
        <ele>13.4</ele>
      </trkpt>
      <trkpt lat=""59.84349"" lon=""17.68857"">
        <ele>13.4</ele>
      </trkpt>
      <trkpt lat=""59.84336"" lon=""17.68853"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.84297"" lon=""17.68822"">
        <ele>12.4</ele>
      </trkpt>
      <trkpt lat=""59.84292"" lon=""17.6881999"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.84288"" lon=""17.68821"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.84284"" lon=""17.68826"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.84281"" lon=""17.68836"">
        <ele>12.4</ele>
      </trkpt>
      <trkpt lat=""59.84272"" lon=""17.68875"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.84268"" lon=""17.68891"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.84264"" lon=""17.689"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.84255"" lon=""17.68915"">
        <ele>12.1</ele>
      </trkpt>
      <trkpt lat=""59.84243"" lon=""17.6893"">
        <ele>11.8</ele>
      </trkpt>
      <trkpt lat=""59.84237"" lon=""17.68941"">
        <ele>11.6</ele>
      </trkpt>
      <trkpt lat=""59.84234"" lon=""17.68955"">
        <ele>11.4</ele>
      </trkpt>
      <trkpt lat=""59.84232"" lon=""17.68974"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.84232"" lon=""17.68974"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.84217"" lon=""17.68976"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.8419"" lon=""17.68972"">
        <ele>11.1</ele>
      </trkpt>
      <trkpt lat=""59.84149"" lon=""17.68965"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.84107"" lon=""17.68957"">
        <ele>10.6</ele>
      </trkpt>
      <trkpt lat=""59.84066"" lon=""17.6895"">
        <ele>10.4</ele>
      </trkpt>
      <trkpt lat=""59.84025"" lon=""17.68943"">
        <ele>10.6</ele>
      </trkpt>
      <trkpt lat=""59.83987"" lon=""17.68938"">
        <ele>10.5</ele>
      </trkpt>
      <trkpt lat=""59.83969"" lon=""17.68937"">
        <ele>10.2</ele>
      </trkpt>
      <trkpt lat=""59.83953"" lon=""17.68938"">
        <ele>9.9</ele>
      </trkpt>
      <trkpt lat=""59.83936"" lon=""17.6894"">
        <ele>9.6</ele>
      </trkpt>
      <trkpt lat=""59.83921"" lon=""17.68944"">
        <ele>9.4</ele>
      </trkpt>
      <trkpt lat=""59.83905"" lon=""17.6895"">
        <ele>9.4</ele>
      </trkpt>
      <trkpt lat=""59.8389"" lon=""17.68957"">
        <ele>9.5</ele>
      </trkpt>
      <trkpt lat=""59.83875"" lon=""17.68965"">
        <ele>9.5</ele>
      </trkpt>
      <trkpt lat=""59.8386"" lon=""17.68975"">
        <ele>9.4</ele>
      </trkpt>
      <trkpt lat=""59.83844"" lon=""17.68988"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.83831"" lon=""17.69"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.8383"" lon=""17.69001"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.83819"" lon=""17.69014"">
        <ele>9.3</ele>
      </trkpt>
      <trkpt lat=""59.83793"" lon=""17.69041"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.83785"" lon=""17.69043"">
        <ele>10.2</ele>
      </trkpt>
      <trkpt lat=""59.83742"" lon=""17.69086"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.83725"" lon=""17.69101"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.83706"" lon=""17.69114"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.83673"" lon=""17.6912999"">
        <ele>8.2</ele>
      </trkpt>
      <trkpt lat=""59.8364"" lon=""17.6913899"">
        <ele>7.5</ele>
      </trkpt>
      <trkpt lat=""59.83636"" lon=""17.6914"">
        <ele>7.4</ele>
      </trkpt>
      <trkpt lat=""59.83632"" lon=""17.69141"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.83632"" lon=""17.69141"">
        <ele>7.3</ele>
      </trkpt>
      <trkpt lat=""59.83633"" lon=""17.69156"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.83633"" lon=""17.69162"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.83634"" lon=""17.69168"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.83634"" lon=""17.69172"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.83634"" lon=""17.69175"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.83632"" lon=""17.69185"">
        <ele>7.2</ele>
      </trkpt>
      <trkpt lat=""59.8363"" lon=""17.69192"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83629"" lon=""17.69197"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83627"" lon=""17.69202"">
        <ele>7.0</ele>
      </trkpt>
      <trkpt lat=""59.83625"" lon=""17.69207"">
        <ele>7.0</ele>
      </trkpt>
      <trkpt lat=""59.83623"" lon=""17.6921"">
        <ele>7.0</ele>
      </trkpt>
      <trkpt lat=""59.83621"" lon=""17.69221"">
        <ele>6.9</ele>
      </trkpt>
      <trkpt lat=""59.83619"" lon=""17.69223"">
        <ele>6.9</ele>
      </trkpt>
      <trkpt lat=""59.83613"" lon=""17.69227"">
        <ele>6.7</ele>
      </trkpt>
      <trkpt lat=""59.836"" lon=""17.69231"">
        <ele>6.4</ele>
      </trkpt>
      <trkpt lat=""59.83571"" lon=""17.69236"">
        <ele>6.3</ele>
      </trkpt>
      <trkpt lat=""59.83514"" lon=""17.69241"">
        <ele>7.7</ele>
      </trkpt>
      <trkpt lat=""59.83505"" lon=""17.6924199"">
        <ele>7.9</ele>
      </trkpt>
      <trkpt lat=""59.83495"" lon=""17.69244"">
        <ele>8.1</ele>
      </trkpt>
      <trkpt lat=""59.83473"" lon=""17.69254"">
        <ele>8.4</ele>
      </trkpt>
      <trkpt lat=""59.83456"" lon=""17.69267"">
        <ele>8.6</ele>
      </trkpt>
      <trkpt lat=""59.83447"" lon=""17.69275"">
        <ele>8.7</ele>
      </trkpt>
      <trkpt lat=""59.83441"" lon=""17.69282"">
        <ele>8.8</ele>
      </trkpt>
      <trkpt lat=""59.83429"" lon=""17.69298"">
        <ele>8.9</ele>
      </trkpt>
      <trkpt lat=""59.83418"" lon=""17.69316"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.83403"" lon=""17.69342"">
        <ele>9.3</ele>
      </trkpt>
      <trkpt lat=""59.83398"" lon=""17.69352"">
        <ele>9.4</ele>
      </trkpt>
      <trkpt lat=""59.83358"" lon=""17.69428"">
        <ele>9.6</ele>
      </trkpt>
      <trkpt lat=""59.83313"" lon=""17.69513"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.83286"" lon=""17.69566"">
        <ele>9.6</ele>
      </trkpt>
      <trkpt lat=""59.83272"" lon=""17.69596"">
        <ele>9.7</ele>
      </trkpt>
      <trkpt lat=""59.83257"" lon=""17.6963"">
        <ele>9.9</ele>
      </trkpt>
      <trkpt lat=""59.83244"" lon=""17.69663"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.83228"" lon=""17.69708"">
        <ele>10.4</ele>
      </trkpt>
      <trkpt lat=""59.83212"" lon=""17.69758"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.83195"" lon=""17.69819"">
        <ele>11.5</ele>
      </trkpt>
      <trkpt lat=""59.83185"" lon=""17.69853"">
        <ele>11.4</ele>
      </trkpt>
      <trkpt lat=""59.83169"" lon=""17.69911"">
        <ele>11.1</ele>
      </trkpt>
      <trkpt lat=""59.83166"" lon=""17.69921"">
        <ele>11.0</ele>
      </trkpt>
      <trkpt lat=""59.83141"" lon=""17.7001199"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.83107"" lon=""17.7014299"">
        <ele>9.6</ele>
      </trkpt>
      <trkpt lat=""59.83072"" lon=""17.70272"">
        <ele>9.4</ele>
      </trkpt>
      <trkpt lat=""59.83037"" lon=""17.70401"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.83029"" lon=""17.70429"">
        <ele>10.1</ele>
      </trkpt>
      <trkpt lat=""59.83029"" lon=""17.70429"">
        <ele>10.1</ele>
      </trkpt>
      <trkpt lat=""59.83002"" lon=""17.7053"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.82976"" lon=""17.70629"">
        <ele>9.9</ele>
      </trkpt>
      <trkpt lat=""59.82943"" lon=""17.70754"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.82932"" lon=""17.70794"">
        <ele>10.4</ele>
      </trkpt>
      <trkpt lat=""59.82923"" lon=""17.70829"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.82917"" lon=""17.70858"">
        <ele>11.0</ele>
      </trkpt>
      <trkpt lat=""59.82911"" lon=""17.70899"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.82892"" lon=""17.71017"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.82872"" lon=""17.71151"">
        <ele>10.8</ele>
      </trkpt>
      <trkpt lat=""59.82851"" lon=""17.71286"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.82835"" lon=""17.71387"">
        <ele>11.0</ele>
      </trkpt>
      <trkpt lat=""59.82811"" lon=""17.71525"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.82791"" lon=""17.7164"">
        <ele>10.8</ele>
      </trkpt>
      <trkpt lat=""59.82768"" lon=""17.71774"">
        <ele>11.0</ele>
      </trkpt>
      <trkpt lat=""59.82749"" lon=""17.7188"">
        <ele>11.0</ele>
      </trkpt>
      <trkpt lat=""59.82736"" lon=""17.71956"">
        <ele>10.4</ele>
      </trkpt>
      <trkpt lat=""59.8272"" lon=""17.72043"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.82704"" lon=""17.72136"">
        <ele>10.3</ele>
      </trkpt>
      <trkpt lat=""59.82686"" lon=""17.7224"">
        <ele>9.6</ele>
      </trkpt>
      <trkpt lat=""59.82669"" lon=""17.7234"">
        <ele>8.1</ele>
      </trkpt>
      <trkpt lat=""59.82657"" lon=""17.72412"">
        <ele>8.1</ele>
      </trkpt>
      <trkpt lat=""59.8265"" lon=""17.72467"">
        <ele>8.7</ele>
      </trkpt>
      <trkpt lat=""59.82646"" lon=""17.72506"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.82643"" lon=""17.7258"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.82641"" lon=""17.72643"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.82639"" lon=""17.7270499"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.82638"" lon=""17.72721"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.82636"" lon=""17.72791"">
        <ele>9.5</ele>
      </trkpt>
      <trkpt lat=""59.82634"" lon=""17.72841"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.82632"" lon=""17.7286499"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.82627"" lon=""17.72905"">
        <ele>10.0</ele>
      </trkpt>
      <trkpt lat=""59.82618"" lon=""17.72953"">
        <ele>9.9</ele>
      </trkpt>
      <trkpt lat=""59.82603"" lon=""17.73"">
        <ele>9.5</ele>
      </trkpt>
      <trkpt lat=""59.8259"" lon=""17.73027"">
        <ele>9.2</ele>
      </trkpt>
      <trkpt lat=""59.82571"" lon=""17.73058"">
        <ele>9.3</ele>
      </trkpt>
      <trkpt lat=""59.82571"" lon=""17.73058"">
        <ele>9.3</ele>
      </trkpt>
      <trkpt lat=""59.82581"" lon=""17.7308999"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.82593"" lon=""17.7313699"">
        <ele>9.3</ele>
      </trkpt>
      <trkpt lat=""59.82617"" lon=""17.7322"">
        <ele>10.2</ele>
      </trkpt>
      <trkpt lat=""59.82632"" lon=""17.73269"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.82655"" lon=""17.73329"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.82685"" lon=""17.73395"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.82723"" lon=""17.73477"">
        <ele>11.7</ele>
      </trkpt>
      <trkpt lat=""59.8276"" lon=""17.73557"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.82784"" lon=""17.7361"">
        <ele>12.5</ele>
      </trkpt>
      <trkpt lat=""59.82795"" lon=""17.73635"">
        <ele>12.5</ele>
      </trkpt>
      <trkpt lat=""59.82801"" lon=""17.73646"">
        <ele>12.5</ele>
      </trkpt>
      <trkpt lat=""59.82801"" lon=""17.73647"">
        <ele>12.5</ele>
      </trkpt>
      <trkpt lat=""59.82839"" lon=""17.73726"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.82873"" lon=""17.73791"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.8288"" lon=""17.73802"">
        <ele>13.6</ele>
      </trkpt>
      <trkpt lat=""59.82886"" lon=""17.73811"">
        <ele>13.6</ele>
      </trkpt>
      <trkpt lat=""59.82897"" lon=""17.73829"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.82902"" lon=""17.73837"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.82922"" lon=""17.73864"">
        <ele>14.5</ele>
      </trkpt>
      <trkpt lat=""59.82949"" lon=""17.73899"">
        <ele>15.3</ele>
      </trkpt>
      <trkpt lat=""59.82973"" lon=""17.73926"">
        <ele>15.7</ele>
      </trkpt>
      <trkpt lat=""59.82997"" lon=""17.73954"">
        <ele>16.0</ele>
      </trkpt>
      <trkpt lat=""59.83034"" lon=""17.7399099"">
        <ele>18.0</ele>
      </trkpt>
      <trkpt lat=""59.83049"" lon=""17.74005"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.83052"" lon=""17.74008"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.83094"" lon=""17.74051"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.83107"" lon=""17.74065"">
        <ele>21.0</ele>
      </trkpt>
      <trkpt lat=""59.83119"" lon=""17.74078"">
        <ele>21.3</ele>
      </trkpt>
      <trkpt lat=""59.83131"" lon=""17.7409"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.8315"" lon=""17.74115"">
        <ele>22.3</ele>
      </trkpt>
      <trkpt lat=""59.83165"" lon=""17.74136"">
        <ele>22.9</ele>
      </trkpt>
      <trkpt lat=""59.83178"" lon=""17.74157"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.83193"" lon=""17.74185"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.83199"" lon=""17.74196"">
        <ele>24.8</ele>
      </trkpt>
      <trkpt lat=""59.83214"" lon=""17.74229"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.83215"" lon=""17.7423"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.8322"" lon=""17.74246"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.83236"" lon=""17.74283"">
        <ele>28.7</ele>
      </trkpt>
      <trkpt lat=""59.83247"" lon=""17.74315"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.83252"" lon=""17.74327"">
        <ele>30.8</ele>
      </trkpt>
      <trkpt lat=""59.83255"" lon=""17.74333"">
        <ele>30.9</ele>
      </trkpt>
      <trkpt lat=""59.83258"" lon=""17.74337"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.83261"" lon=""17.7434"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.83261"" lon=""17.7434"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.83256"" lon=""17.74358"">
        <ele>31.2</ele>
      </trkpt>
      <trkpt lat=""59.83251"" lon=""17.74374"">
        <ele>31.5</ele>
      </trkpt>
      <trkpt lat=""59.83248"" lon=""17.74382"">
        <ele>31.4</ele>
      </trkpt>
      <trkpt lat=""59.83245"" lon=""17.7439399"">
        <ele>31.4</ele>
      </trkpt>
      <trkpt lat=""59.83243"" lon=""17.74406"">
        <ele>31.4</ele>
      </trkpt>
      <trkpt lat=""59.83243"" lon=""17.74419"">
        <ele>31.6</ele>
      </trkpt>
      <trkpt lat=""59.83242"" lon=""17.74431"">
        <ele>31.8</ele>
      </trkpt>
      <trkpt lat=""59.83241"" lon=""17.74446"">
        <ele>32.1</ele>
      </trkpt>
      <trkpt lat=""59.83241"" lon=""17.74457"">
        <ele>32.3</ele>
      </trkpt>
      <trkpt lat=""59.8324"" lon=""17.74467"">
        <ele>32.5</ele>
      </trkpt>
      <trkpt lat=""59.83239"" lon=""17.74477"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.83237"" lon=""17.7448799"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.83236"" lon=""17.74494"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.83234"" lon=""17.74498"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.83231"" lon=""17.74503"">
        <ele>32.6</ele>
      </trkpt>
      <trkpt lat=""59.83229"" lon=""17.74506"">
        <ele>32.4</ele>
      </trkpt>
      <trkpt lat=""59.8321"" lon=""17.74519"">
        <ele>30.9</ele>
      </trkpt>
      <trkpt lat=""59.83208"" lon=""17.74521"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.83205"" lon=""17.74523"">
        <ele>30.5</ele>
      </trkpt>
      <trkpt lat=""59.83201"" lon=""17.7452599"">
        <ele>30.2</ele>
      </trkpt>
      <trkpt lat=""59.83194"" lon=""17.74532"">
        <ele>29.7</ele>
      </trkpt>
      <trkpt lat=""59.83188"" lon=""17.74539"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.83172"" lon=""17.74561"">
        <ele>28.3</ele>
      </trkpt>
      <trkpt lat=""59.83166"" lon=""17.7457"">
        <ele>28.0</ele>
      </trkpt>
      <trkpt lat=""59.83161"" lon=""17.74579"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.83158"" lon=""17.74587"">
        <ele>27.3</ele>
      </trkpt>
      <trkpt lat=""59.83155"" lon=""17.74595"">
        <ele>27.1</ele>
      </trkpt>
      <trkpt lat=""59.83153"" lon=""17.74605"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.83152"" lon=""17.74615"">
        <ele>26.7</ele>
      </trkpt>
      <trkpt lat=""59.8315"" lon=""17.7462899"">
        <ele>26.5</ele>
      </trkpt>
      <trkpt lat=""59.83147"" lon=""17.7466"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.83146"" lon=""17.74675"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.83142"" lon=""17.74715"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.83135"" lon=""17.74784"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.8313"" lon=""17.7483"">
        <ele>27.5</ele>
      </trkpt>
      <trkpt lat=""59.83123"" lon=""17.74867"">
        <ele>27.9</ele>
      </trkpt>
      <trkpt lat=""59.8311"" lon=""17.7491"">
        <ele>28.2</ele>
      </trkpt>
      <trkpt lat=""59.83096"" lon=""17.74968"">
        <ele>28.8</ele>
      </trkpt>
      <trkpt lat=""59.83089"" lon=""17.74992"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.83081"" lon=""17.75025"">
        <ele>29.8</ele>
      </trkpt>
      <trkpt lat=""59.83068"" lon=""17.75068"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.83053"" lon=""17.75123"">
        <ele>31.4</ele>
      </trkpt>
      <trkpt lat=""59.83039"" lon=""17.75181"">
        <ele>31.8</ele>
      </trkpt>
      <trkpt lat=""59.83034"" lon=""17.75206"">
        <ele>31.5</ele>
      </trkpt>
      <trkpt lat=""59.83029"" lon=""17.75231"">
        <ele>31.3</ele>
      </trkpt>
      <trkpt lat=""59.83021"" lon=""17.75264"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.83014"" lon=""17.7528"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.83012"" lon=""17.75285"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.83006"" lon=""17.75297"">
        <ele>30.5</ele>
      </trkpt>
      <trkpt lat=""59.82997"" lon=""17.75315"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.82989"" lon=""17.75332"">
        <ele>30.2</ele>
      </trkpt>
      <trkpt lat=""59.8298"" lon=""17.75349"">
        <ele>29.6</ele>
      </trkpt>
      <trkpt lat=""59.82973"" lon=""17.75369"">
        <ele>29.1</ele>
      </trkpt>
      <trkpt lat=""59.82962"" lon=""17.75399"">
        <ele>28.3</ele>
      </trkpt>
      <trkpt lat=""59.82953"" lon=""17.75425"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.82944"" lon=""17.75463"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.82937"" lon=""17.7551099"">
        <ele>27.0</ele>
      </trkpt>
      <trkpt lat=""59.82927"" lon=""17.75581"">
        <ele>26.5</ele>
      </trkpt>
      <trkpt lat=""59.82919"" lon=""17.75649"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.82912"" lon=""17.75711"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.8291"" lon=""17.75748"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.82908"" lon=""17.75796"">
        <ele>27.3</ele>
      </trkpt>
      <trkpt lat=""59.82906"" lon=""17.75856"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.82904"" lon=""17.75942"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.82902"" lon=""17.75997"">
        <ele>26.5</ele>
      </trkpt>
      <trkpt lat=""59.82899"" lon=""17.76042"">
        <ele>26.5</ele>
      </trkpt>
      <trkpt lat=""59.82895"" lon=""17.7607"">
        <ele>26.4</ele>
      </trkpt>
      <trkpt lat=""59.82888"" lon=""17.76098"">
        <ele>26.3</ele>
      </trkpt>
      <trkpt lat=""59.82879"" lon=""17.76129"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.82868"" lon=""17.76166"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.82853"" lon=""17.76213"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.82851"" lon=""17.76218"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.82848"" lon=""17.76229"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.82841"" lon=""17.76258"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.82833"" lon=""17.76302"">
        <ele>26.6</ele>
      </trkpt>
      <trkpt lat=""59.82822"" lon=""17.7636499"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.82812"" lon=""17.7642099"">
        <ele>24.1</ele>
      </trkpt>
      <trkpt lat=""59.82803"" lon=""17.76465"">
        <ele>22.5</ele>
      </trkpt>
      <trkpt lat=""59.82795"" lon=""17.76502"">
        <ele>21.2</ele>
      </trkpt>
      <trkpt lat=""59.82786"" lon=""17.76531"">
        <ele>20.1</ele>
      </trkpt>
      <trkpt lat=""59.82771"" lon=""17.76583"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.82751"" lon=""17.76644"">
        <ele>16.3</ele>
      </trkpt>
      <trkpt lat=""59.82714"" lon=""17.76768"">
        <ele>14.7</ele>
      </trkpt>
      <trkpt lat=""59.82707"" lon=""17.76793"">
        <ele>14.5</ele>
      </trkpt>
      <trkpt lat=""59.82702"" lon=""17.76813"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.82697"" lon=""17.76831"">
        <ele>14.1</ele>
      </trkpt>
      <trkpt lat=""59.82694"" lon=""17.76845"">
        <ele>14.0</ele>
      </trkpt>
      <trkpt lat=""59.82691"" lon=""17.7686"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.82689"" lon=""17.76875"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.82687"" lon=""17.76884"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.82685"" lon=""17.76902"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.82684"" lon=""17.76914"">
        <ele>13.6</ele>
      </trkpt>
      <trkpt lat=""59.82683"" lon=""17.76925"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.82683"" lon=""17.76938"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.82682"" lon=""17.76958"">
        <ele>14.0</ele>
      </trkpt>
      <trkpt lat=""59.82682"" lon=""17.76976"">
        <ele>14.1</ele>
      </trkpt>
      <trkpt lat=""59.82682"" lon=""17.76992"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.82683"" lon=""17.77007"">
        <ele>14.4</ele>
      </trkpt>
      <trkpt lat=""59.82684"" lon=""17.77032"">
        <ele>14.4</ele>
      </trkpt>
      <trkpt lat=""59.82686"" lon=""17.77076"">
        <ele>14.5</ele>
      </trkpt>
      <trkpt lat=""59.82687"" lon=""17.77084"">
        <ele>14.5</ele>
      </trkpt>
      <trkpt lat=""59.82688"" lon=""17.77104"">
        <ele>14.6</ele>
      </trkpt>
      <trkpt lat=""59.82691"" lon=""17.77166"">
        <ele>14.9</ele>
      </trkpt>
      <trkpt lat=""59.82694"" lon=""17.77239"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.82695"" lon=""17.77246"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.82696"" lon=""17.77284"">
        <ele>14.6</ele>
      </trkpt>
      <trkpt lat=""59.82697"" lon=""17.77301"">
        <ele>14.5</ele>
      </trkpt>
      <trkpt lat=""59.82701"" lon=""17.7739"">
        <ele>14.2</ele>
      </trkpt>
      <trkpt lat=""59.82706"" lon=""17.77493"">
        <ele>14.0</ele>
      </trkpt>
      <trkpt lat=""59.82706"" lon=""17.77509"">
        <ele>14.0</ele>
      </trkpt>
      <trkpt lat=""59.82707"" lon=""17.77523"">
        <ele>14.1</ele>
      </trkpt>
      <trkpt lat=""59.82706"" lon=""17.7754"">
        <ele>14.2</ele>
      </trkpt>
      <trkpt lat=""59.82706"" lon=""17.77554"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.82705"" lon=""17.77562"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.827"" lon=""17.77654"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.827"" lon=""17.77671"">
        <ele>15.2</ele>
      </trkpt>
      <trkpt lat=""59.82699"" lon=""17.77686"">
        <ele>15.1</ele>
      </trkpt>
      <trkpt lat=""59.82699"" lon=""17.77696"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.827"" lon=""17.77708"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.82701"" lon=""17.7772"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.82703"" lon=""17.77747"">
        <ele>14.9</ele>
      </trkpt>
      <trkpt lat=""59.82703"" lon=""17.77753"">
        <ele>14.9</ele>
      </trkpt>
      <trkpt lat=""59.82702"" lon=""17.7776"">
        <ele>14.8</ele>
      </trkpt>
      <trkpt lat=""59.82702"" lon=""17.7776"">
        <ele>14.8</ele>
      </trkpt>
      <trkpt lat=""59.82699"" lon=""17.77766"">
        <ele>14.7</ele>
      </trkpt>
      <trkpt lat=""59.82695"" lon=""17.77771"">
        <ele>14.6</ele>
      </trkpt>
      <trkpt lat=""59.8269"" lon=""17.77775"">
        <ele>14.5</ele>
      </trkpt>
      <trkpt lat=""59.82658"" lon=""17.77792"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.82603"" lon=""17.77822"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.82541"" lon=""17.7785699"">
        <ele>14.0</ele>
      </trkpt>
      <trkpt lat=""59.82499"" lon=""17.77881"">
        <ele>14.0</ele>
      </trkpt>
      <trkpt lat=""59.82493"" lon=""17.77886"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.82484"" lon=""17.77893"">
        <ele>14.6</ele>
      </trkpt>
      <trkpt lat=""59.82478"" lon=""17.779"">
        <ele>14.8</ele>
      </trkpt>
      <trkpt lat=""59.82472"" lon=""17.77908"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.82467"" lon=""17.77915"">
        <ele>15.2</ele>
      </trkpt>
      <trkpt lat=""59.82461"" lon=""17.77926"">
        <ele>15.4</ele>
      </trkpt>
      <trkpt lat=""59.82455"" lon=""17.77938"">
        <ele>15.6</ele>
      </trkpt>
      <trkpt lat=""59.82442"" lon=""17.77967"">
        <ele>15.9</ele>
      </trkpt>
      <trkpt lat=""59.82426"" lon=""17.78002"">
        <ele>15.9</ele>
      </trkpt>
      <trkpt lat=""59.8242"" lon=""17.78013"">
        <ele>15.8</ele>
      </trkpt>
      <trkpt lat=""59.82412"" lon=""17.7802599"">
        <ele>15.8</ele>
      </trkpt>
      <trkpt lat=""59.82404"" lon=""17.78038"">
        <ele>15.8</ele>
      </trkpt>
      <trkpt lat=""59.82398"" lon=""17.78048"">
        <ele>15.9</ele>
      </trkpt>
      <trkpt lat=""59.8239"" lon=""17.78059"">
        <ele>15.9</ele>
      </trkpt>
      <trkpt lat=""59.82365"" lon=""17.78093"">
        <ele>16.0</ele>
      </trkpt>
      <trkpt lat=""59.82323"" lon=""17.78156"">
        <ele>15.8</ele>
      </trkpt>
      <trkpt lat=""59.82284"" lon=""17.78208"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.82271"" lon=""17.78221"">
        <ele>17.3</ele>
      </trkpt>
      <trkpt lat=""59.82262"" lon=""17.7823"">
        <ele>17.7</ele>
      </trkpt>
      <trkpt lat=""59.82255"" lon=""17.78237"">
        <ele>17.9</ele>
      </trkpt>
      <trkpt lat=""59.82245"" lon=""17.78245"">
        <ele>18.2</ele>
      </trkpt>
      <trkpt lat=""59.82236"" lon=""17.7825099"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.82218"" lon=""17.7826"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.82195"" lon=""17.78271"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.82178"" lon=""17.78279"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.82166"" lon=""17.78285"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.82151"" lon=""17.78294"">
        <ele>20.1</ele>
      </trkpt>
      <trkpt lat=""59.82138"" lon=""17.783"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.82128"" lon=""17.78304"">
        <ele>21.3</ele>
      </trkpt>
      <trkpt lat=""59.8212"" lon=""17.78307"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.82113"" lon=""17.78308"">
        <ele>22.2</ele>
      </trkpt>
      <trkpt lat=""59.82107"" lon=""17.78309"">
        <ele>22.6</ele>
      </trkpt>
      <trkpt lat=""59.82092"" lon=""17.78309"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.82065"" lon=""17.78309"">
        <ele>25.1</ele>
      </trkpt>
      <trkpt lat=""59.82047"" lon=""17.78308"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.82038"" lon=""17.78307"">
        <ele>26.5</ele>
      </trkpt>
      <trkpt lat=""59.82033"" lon=""17.78307"">
        <ele>26.7</ele>
      </trkpt>
      <trkpt lat=""59.82029"" lon=""17.78306"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.82025"" lon=""17.78305"">
        <ele>27.1</ele>
      </trkpt>
      <trkpt lat=""59.82022"" lon=""17.78303"">
        <ele>27.3</ele>
      </trkpt>
      <trkpt lat=""59.82018"" lon=""17.783"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.82014"" lon=""17.78296"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.8201"" lon=""17.78291"">
        <ele>28.1</ele>
      </trkpt>
      <trkpt lat=""59.81995"" lon=""17.78267"">
        <ele>28.9</ele>
      </trkpt>
      <trkpt lat=""59.81986"" lon=""17.78254"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.81982"" lon=""17.7825"">
        <ele>29.4</ele>
      </trkpt>
      <trkpt lat=""59.81978"" lon=""17.78248"">
        <ele>29.6</ele>
      </trkpt>
      <trkpt lat=""59.81974"" lon=""17.78246"">
        <ele>29.7</ele>
      </trkpt>
      <trkpt lat=""59.81964"" lon=""17.78243"">
        <ele>29.9</ele>
      </trkpt>
      <trkpt lat=""59.81961"" lon=""17.78241"">
        <ele>30.0</ele>
      </trkpt>
      <trkpt lat=""59.8196"" lon=""17.78241"">
        <ele>30.1</ele>
      </trkpt>
      <trkpt lat=""59.81956"" lon=""17.78234"">
        <ele>30.2</ele>
      </trkpt>
      <trkpt lat=""59.81953"" lon=""17.78224"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.8195"" lon=""17.78206"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.81949"" lon=""17.78192"">
        <ele>30.9</ele>
      </trkpt>
      <trkpt lat=""59.81948"" lon=""17.78172"">
        <ele>31.2</ele>
      </trkpt>
      <trkpt lat=""59.81948"" lon=""17.78146"">
        <ele>31.8</ele>
      </trkpt>
      <trkpt lat=""59.81948"" lon=""17.78109"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.81947"" lon=""17.78091"">
        <ele>33.2</ele>
      </trkpt>
      <trkpt lat=""59.81945"" lon=""17.78076"">
        <ele>33.5</ele>
      </trkpt>
      <trkpt lat=""59.81943"" lon=""17.78063"">
        <ele>33.7</ele>
      </trkpt>
      <trkpt lat=""59.81939"" lon=""17.7804499"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.81926"" lon=""17.78"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.81923"" lon=""17.77986"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.81922"" lon=""17.77973"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.81919"" lon=""17.77954"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.81917"" lon=""17.7793199"">
        <ele>34.8</ele>
      </trkpt>
      <trkpt lat=""59.81916"" lon=""17.77925"">
        <ele>34.9</ele>
      </trkpt>
      <trkpt lat=""59.81915"" lon=""17.77921"">
        <ele>34.8</ele>
      </trkpt>
      <trkpt lat=""59.81912"" lon=""17.77908"">
        <ele>34.7</ele>
      </trkpt>
      <trkpt lat=""59.81907"" lon=""17.7789499"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.81903"" lon=""17.77883"">
        <ele>34.1</ele>
      </trkpt>
      <trkpt lat=""59.81897"" lon=""17.77872"">
        <ele>33.8</ele>
      </trkpt>
      <trkpt lat=""59.81884"" lon=""17.7784799"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.81864"" lon=""17.77812"">
        <ele>33.5</ele>
      </trkpt>
      <trkpt lat=""59.81858"" lon=""17.77802"">
        <ele>33.7</ele>
      </trkpt>
      <trkpt lat=""59.81852"" lon=""17.77795"">
        <ele>33.7</ele>
      </trkpt>
      <trkpt lat=""59.81844"" lon=""17.7779"">
        <ele>33.6</ele>
      </trkpt>
      <trkpt lat=""59.81837"" lon=""17.77789"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.81824"" lon=""17.77791"">
        <ele>32.4</ele>
      </trkpt>
      <trkpt lat=""59.8181"" lon=""17.77794"">
        <ele>31.4</ele>
      </trkpt>
      <trkpt lat=""59.8179"" lon=""17.77794"">
        <ele>30.0</ele>
      </trkpt>
      <trkpt lat=""59.81765"" lon=""17.77794"">
        <ele>28.4</ele>
      </trkpt>
      <trkpt lat=""59.81739"" lon=""17.77793"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.81729"" lon=""17.7779"">
        <ele>26.5</ele>
      </trkpt>
      <trkpt lat=""59.81722"" lon=""17.77786"">
        <ele>26.3</ele>
      </trkpt>
      <trkpt lat=""59.81717"" lon=""17.77779"">
        <ele>26.3</ele>
      </trkpt>
      <trkpt lat=""59.81712"" lon=""17.77769"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.8171"" lon=""17.77758"">
        <ele>26.4</ele>
      </trkpt>
      <trkpt lat=""59.81705"" lon=""17.77724"">
        <ele>26.7</ele>
      </trkpt>
      <trkpt lat=""59.817"" lon=""17.77689"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.81696"" lon=""17.77666"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.81689"" lon=""17.7764099"">
        <ele>25.8</ele>
      </trkpt>
      <trkpt lat=""59.81685"" lon=""17.77628"">
        <ele>25.2</ele>
      </trkpt>
      <trkpt lat=""59.81681"" lon=""17.77616"">
        <ele>24.7</ele>
      </trkpt>
      <trkpt lat=""59.81678"" lon=""17.77608"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.81674"" lon=""17.77598"">
        <ele>23.8</ele>
      </trkpt>
      <trkpt lat=""59.81669"" lon=""17.77588"">
        <ele>23.3</ele>
      </trkpt>
      <trkpt lat=""59.81663"" lon=""17.77579"">
        <ele>22.8</ele>
      </trkpt>
      <trkpt lat=""59.81655"" lon=""17.77571"">
        <ele>22.3</ele>
      </trkpt>
      <trkpt lat=""59.81646"" lon=""17.77562"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.8163"" lon=""17.77548"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.8161"" lon=""17.77534"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.81585"" lon=""17.77516"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.81544"" lon=""17.77489"">
        <ele>16.6</ele>
      </trkpt>
      <trkpt lat=""59.81489"" lon=""17.77453"">
        <ele>15.4</ele>
      </trkpt>
      <trkpt lat=""59.81434"" lon=""17.77415"">
        <ele>14.4</ele>
      </trkpt>
      <trkpt lat=""59.81398"" lon=""17.77391"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.81384"" lon=""17.77382"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.81376"" lon=""17.77378"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.81368"" lon=""17.77378"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.81362"" lon=""17.7738"">
        <ele>13.6</ele>
      </trkpt>
      <trkpt lat=""59.81352"" lon=""17.77386"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.81341"" lon=""17.77394"">
        <ele>13.3</ele>
      </trkpt>
      <trkpt lat=""59.81315"" lon=""17.77418"">
        <ele>13.4</ele>
      </trkpt>
      <trkpt lat=""59.81248"" lon=""17.77476"">
        <ele>15.8</ele>
      </trkpt>
      <trkpt lat=""59.81219"" lon=""17.77502"">
        <ele>18.2</ele>
      </trkpt>
      <trkpt lat=""59.81214"" lon=""17.77508"">
        <ele>18.5</ele>
      </trkpt>
      <trkpt lat=""59.8121"" lon=""17.77516"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.81207"" lon=""17.77526"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.81205"" lon=""17.77544"">
        <ele>18.4</ele>
      </trkpt>
      <trkpt lat=""59.81203"" lon=""17.77553"">
        <ele>18.4</ele>
      </trkpt>
      <trkpt lat=""59.81202"" lon=""17.77556"">
        <ele>18.4</ele>
      </trkpt>
      <trkpt lat=""59.81194"" lon=""17.77564"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.8118"" lon=""17.77579"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.8115"" lon=""17.7760399"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.81126"" lon=""17.77624"">
        <ele>17.5</ele>
      </trkpt>
      <trkpt lat=""59.81111"" lon=""17.7763199"">
        <ele>17.1</ele>
      </trkpt>
      <trkpt lat=""59.81105"" lon=""17.77633"">
        <ele>17.0</ele>
      </trkpt>
      <trkpt lat=""59.811"" lon=""17.7763199"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.81098"" lon=""17.77631"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.81094"" lon=""17.77628"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.8109"" lon=""17.77624"">
        <ele>16.7</ele>
      </trkpt>
      <trkpt lat=""59.81082"" lon=""17.77617"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.8107"" lon=""17.77602"">
        <ele>16.1</ele>
      </trkpt>
      <trkpt lat=""59.81057"" lon=""17.77586"">
        <ele>15.7</ele>
      </trkpt>
      <trkpt lat=""59.8104"" lon=""17.77562"">
        <ele>15.3</ele>
      </trkpt>
      <trkpt lat=""59.81022"" lon=""17.77539"">
        <ele>14.9</ele>
      </trkpt>
      <trkpt lat=""59.81012"" lon=""17.77526"">
        <ele>14.6</ele>
      </trkpt>
      <trkpt lat=""59.81004"" lon=""17.77517"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.80984"" lon=""17.77501"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.80954"" lon=""17.7748"">
        <ele>13.2</ele>
      </trkpt>
      <trkpt lat=""59.80932"" lon=""17.7746299"">
        <ele>12.7</ele>
      </trkpt>
      <trkpt lat=""59.80908"" lon=""17.77448"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.80886"" lon=""17.7743499"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.80819"" lon=""17.77398"">
        <ele>11.4</ele>
      </trkpt>
      <trkpt lat=""59.80726"" lon=""17.77347"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.80684"" lon=""17.77325"">
        <ele>11.1</ele>
      </trkpt>
      <trkpt lat=""59.80642"" lon=""17.77303"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.80603"" lon=""17.77282"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.80576"" lon=""17.77267"">
        <ele>11.1</ele>
      </trkpt>
      <trkpt lat=""59.8055"" lon=""17.77249"">
        <ele>11.4</ele>
      </trkpt>
      <trkpt lat=""59.80541"" lon=""17.77242"">
        <ele>11.5</ele>
      </trkpt>
      <trkpt lat=""59.80531"" lon=""17.77234"">
        <ele>11.6</ele>
      </trkpt>
      <trkpt lat=""59.80515"" lon=""17.7721899"">
        <ele>11.8</ele>
      </trkpt>
      <trkpt lat=""59.80495"" lon=""17.77196"">
        <ele>12.0</ele>
      </trkpt>
      <trkpt lat=""59.80478"" lon=""17.77174"">
        <ele>12.0</ele>
      </trkpt>
      <trkpt lat=""59.80463"" lon=""17.77152"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.80436"" lon=""17.77111"">
        <ele>11.8</ele>
      </trkpt>
      <trkpt lat=""59.80395"" lon=""17.77044"">
        <ele>12.0</ele>
      </trkpt>
      <trkpt lat=""59.80354"" lon=""17.76977"">
        <ele>12.4</ele>
      </trkpt>
      <trkpt lat=""59.80338"" lon=""17.76951"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.80338"" lon=""17.76951"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.80314"" lon=""17.77002"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.80285"" lon=""17.77063"">
        <ele>14.0</ele>
      </trkpt>
      <trkpt lat=""59.80254"" lon=""17.77126"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.8021"" lon=""17.7721899"">
        <ele>15.2</ele>
      </trkpt>
      <trkpt lat=""59.80172"" lon=""17.77295"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.80135"" lon=""17.77372"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.80102"" lon=""17.77441"">
        <ele>17.6</ele>
      </trkpt>
      <trkpt lat=""59.80078"" lon=""17.77489"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.80061"" lon=""17.77522"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.80045"" lon=""17.77552"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.80023"" lon=""17.77591"">
        <ele>21.4</ele>
      </trkpt>
      <trkpt lat=""59.8"" lon=""17.77631"">
        <ele>21.0</ele>
      </trkpt>
      <trkpt lat=""59.79983"" lon=""17.77661"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.7996"" lon=""17.777"">
        <ele>21.0</ele>
      </trkpt>
      <trkpt lat=""59.79939"" lon=""17.77737"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.79922"" lon=""17.77767"">
        <ele>20.4</ele>
      </trkpt>
      <trkpt lat=""59.79898"" lon=""17.77802"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.79882"" lon=""17.77825"">
        <ele>19.9</ele>
      </trkpt>
      <trkpt lat=""59.79866"" lon=""17.77846"">
        <ele>20.4</ele>
      </trkpt>
      <trkpt lat=""59.79848"" lon=""17.77873"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.79832"" lon=""17.77899"">
        <ele>21.0</ele>
      </trkpt>
      <trkpt lat=""59.79823"" lon=""17.77916"">
        <ele>21.5</ele>
      </trkpt>
      <trkpt lat=""59.79814"" lon=""17.77933"">
        <ele>22.0</ele>
      </trkpt>
      <trkpt lat=""59.79803"" lon=""17.77957"">
        <ele>22.6</ele>
      </trkpt>
      <trkpt lat=""59.79793"" lon=""17.77982"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.79782"" lon=""17.78013"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.79768"" lon=""17.7805399"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.79754"" lon=""17.78095"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.7973"" lon=""17.78163"">
        <ele>21.4</ele>
      </trkpt>
      <trkpt lat=""59.79705"" lon=""17.78233"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.79685"" lon=""17.78286"">
        <ele>21.6</ele>
      </trkpt>
      <trkpt lat=""59.79665"" lon=""17.7833599"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.79651"" lon=""17.7837299"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.79639"" lon=""17.7841"">
        <ele>21.9</ele>
      </trkpt>
      <trkpt lat=""59.79633"" lon=""17.78431"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.7963"" lon=""17.78442"">
        <ele>21.6</ele>
      </trkpt>
      <trkpt lat=""59.79618"" lon=""17.78497"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.79612"" lon=""17.78521"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.79606"" lon=""17.78545"">
        <ele>19.9</ele>
      </trkpt>
      <trkpt lat=""59.796"" lon=""17.78566"">
        <ele>19.5</ele>
      </trkpt>
      <trkpt lat=""59.79591"" lon=""17.7859"">
        <ele>19.0</ele>
      </trkpt>
      <trkpt lat=""59.79582"" lon=""17.7861"">
        <ele>18.5</ele>
      </trkpt>
      <trkpt lat=""59.79573"" lon=""17.78629"">
        <ele>18.1</ele>
      </trkpt>
      <trkpt lat=""59.79558"" lon=""17.78656"">
        <ele>18.0</ele>
      </trkpt>
      <trkpt lat=""59.79536"" lon=""17.78696"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.79518"" lon=""17.78729"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.79499"" lon=""17.78766"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.79488"" lon=""17.7879"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.79481"" lon=""17.78807"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.79473"" lon=""17.78827"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.79466"" lon=""17.7885"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.79455"" lon=""17.78888"">
        <ele>19.5</ele>
      </trkpt>
      <trkpt lat=""59.79455"" lon=""17.78888"">
        <ele>19.5</ele>
      </trkpt>
      <trkpt lat=""59.79435"" lon=""17.78862"">
        <ele>22.3</ele>
      </trkpt>
      <trkpt lat=""59.79424"" lon=""17.78846"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.79416"" lon=""17.78829"">
        <ele>25.2</ele>
      </trkpt>
      <trkpt lat=""59.7941"" lon=""17.78812"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.79405"" lon=""17.78797"">
        <ele>27.0</ele>
      </trkpt>
      <trkpt lat=""59.79401"" lon=""17.7877"">
        <ele>28.3</ele>
      </trkpt>
      <trkpt lat=""59.79394"" lon=""17.78726"">
        <ele>30.1</ele>
      </trkpt>
      <trkpt lat=""59.79392"" lon=""17.78716"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.79389"" lon=""17.78694"">
        <ele>31.1</ele>
      </trkpt>
      <trkpt lat=""59.79386"" lon=""17.78677"">
        <ele>31.7</ele>
      </trkpt>
      <trkpt lat=""59.79385"" lon=""17.78674"">
        <ele>31.8</ele>
      </trkpt>
      <trkpt lat=""59.79379"" lon=""17.78652"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.79373"" lon=""17.78638"">
        <ele>33.6</ele>
      </trkpt>
      <trkpt lat=""59.79366"" lon=""17.78625"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.7936"" lon=""17.78615"">
        <ele>34.9</ele>
      </trkpt>
      <trkpt lat=""59.79351"" lon=""17.78607"">
        <ele>35.4</ele>
      </trkpt>
      <trkpt lat=""59.79341"" lon=""17.78601"">
        <ele>35.9</ele>
      </trkpt>
      <trkpt lat=""59.7932"" lon=""17.78595"">
        <ele>36.0</ele>
      </trkpt>
      <trkpt lat=""59.7929"" lon=""17.78593"">
        <ele>35.4</ele>
      </trkpt>
      <trkpt lat=""59.79269"" lon=""17.78592"">
        <ele>35.0</ele>
      </trkpt>
      <trkpt lat=""59.79248"" lon=""17.78591"">
        <ele>34.8</ele>
      </trkpt>
      <trkpt lat=""59.79234"" lon=""17.7858899"">
        <ele>35.7</ele>
      </trkpt>
      <trkpt lat=""59.79225"" lon=""17.78585"">
        <ele>36.4</ele>
      </trkpt>
      <trkpt lat=""59.79213"" lon=""17.78579"">
        <ele>37.4</ele>
      </trkpt>
      <trkpt lat=""59.79208"" lon=""17.78576"">
        <ele>37.8</ele>
      </trkpt>
      <trkpt lat=""59.79194"" lon=""17.78566"">
        <ele>39.0</ele>
      </trkpt>
      <trkpt lat=""59.79178"" lon=""17.78553"">
        <ele>40.4</ele>
      </trkpt>
      <trkpt lat=""59.79164"" lon=""17.78537"">
        <ele>41.9</ele>
      </trkpt>
      <trkpt lat=""59.79152"" lon=""17.78523"">
        <ele>43.3</ele>
      </trkpt>
      <trkpt lat=""59.79134"" lon=""17.78499"">
        <ele>45.4</ele>
      </trkpt>
      <trkpt lat=""59.79123"" lon=""17.78487"">
        <ele>46.4</ele>
      </trkpt>
      <trkpt lat=""59.7911"" lon=""17.78477"">
        <ele>47.4</ele>
      </trkpt>
      <trkpt lat=""59.791"" lon=""17.78474"">
        <ele>48.2</ele>
      </trkpt>
      <trkpt lat=""59.7909"" lon=""17.78474"">
        <ele>48.9</ele>
      </trkpt>
      <trkpt lat=""59.7908"" lon=""17.78477"">
        <ele>49.3</ele>
      </trkpt>
      <trkpt lat=""59.79045"" lon=""17.78484"">
        <ele>49.4</ele>
      </trkpt>
      <trkpt lat=""59.79014"" lon=""17.78489"">
        <ele>49.4</ele>
      </trkpt>
      <trkpt lat=""59.78972"" lon=""17.78499"">
        <ele>49.0</ele>
      </trkpt>
      <trkpt lat=""59.78953"" lon=""17.78506"">
        <ele>49.0</ele>
      </trkpt>
      <trkpt lat=""59.78939"" lon=""17.78516"">
        <ele>48.9</ele>
      </trkpt>
      <trkpt lat=""59.78928"" lon=""17.78529"">
        <ele>48.7</ele>
      </trkpt>
      <trkpt lat=""59.78907"" lon=""17.78556"">
        <ele>48.4</ele>
      </trkpt>
      <trkpt lat=""59.78871"" lon=""17.78605"">
        <ele>47.5</ele>
      </trkpt>
      <trkpt lat=""59.7884"" lon=""17.78651"">
        <ele>45.7</ele>
      </trkpt>
      <trkpt lat=""59.78817"" lon=""17.78678"">
        <ele>45.3</ele>
      </trkpt>
      <trkpt lat=""59.78793"" lon=""17.78704"">
        <ele>45.4</ele>
      </trkpt>
      <trkpt lat=""59.78777"" lon=""17.78723"">
        <ele>45.2</ele>
      </trkpt>
      <trkpt lat=""59.78766"" lon=""17.78738"">
        <ele>45.0</ele>
      </trkpt>
      <trkpt lat=""59.78746"" lon=""17.78774"">
        <ele>43.7</ele>
      </trkpt>
      <trkpt lat=""59.78728"" lon=""17.78804"">
        <ele>42.5</ele>
      </trkpt>
      <trkpt lat=""59.78716"" lon=""17.78823"">
        <ele>41.8</ele>
      </trkpt>
      <trkpt lat=""59.78703"" lon=""17.78837"">
        <ele>41.5</ele>
      </trkpt>
      <trkpt lat=""59.78693"" lon=""17.78847"">
        <ele>41.4</ele>
      </trkpt>
      <trkpt lat=""59.78681"" lon=""17.78855"">
        <ele>41.4</ele>
      </trkpt>
      <trkpt lat=""59.7867"" lon=""17.7886099"">
        <ele>41.3</ele>
      </trkpt>
      <trkpt lat=""59.78658"" lon=""17.78865"">
        <ele>40.8</ele>
      </trkpt>
      <trkpt lat=""59.78647"" lon=""17.78866"">
        <ele>40.3</ele>
      </trkpt>
      <trkpt lat=""59.78637"" lon=""17.78866"">
        <ele>39.9</ele>
      </trkpt>
      <trkpt lat=""59.7862"" lon=""17.7886"">
        <ele>39.5</ele>
      </trkpt>
      <trkpt lat=""59.78598"" lon=""17.78854"">
        <ele>38.9</ele>
      </trkpt>
      <trkpt lat=""59.78579"" lon=""17.78848"">
        <ele>38.2</ele>
      </trkpt>
      <trkpt lat=""59.78568"" lon=""17.78842"">
        <ele>37.8</ele>
      </trkpt>
      <trkpt lat=""59.78558"" lon=""17.78834"">
        <ele>37.5</ele>
      </trkpt>
      <trkpt lat=""59.78543"" lon=""17.7882"">
        <ele>37.2</ele>
      </trkpt>
      <trkpt lat=""59.78521"" lon=""17.78794"">
        <ele>36.9</ele>
      </trkpt>
      <trkpt lat=""59.78493"" lon=""17.78759"">
        <ele>36.2</ele>
      </trkpt>
      <trkpt lat=""59.78477"" lon=""17.7874"">
        <ele>35.6</ele>
      </trkpt>
      <trkpt lat=""59.78471"" lon=""17.78734"">
        <ele>35.4</ele>
      </trkpt>
      <trkpt lat=""59.78463"" lon=""17.78727"">
        <ele>34.9</ele>
      </trkpt>
      <trkpt lat=""59.78451"" lon=""17.78714"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.78444"" lon=""17.78708"">
        <ele>33.8</ele>
      </trkpt>
      <trkpt lat=""59.78415"" lon=""17.78687"">
        <ele>31.7</ele>
      </trkpt>
      <trkpt lat=""59.78385"" lon=""17.78666"">
        <ele>30.9</ele>
      </trkpt>
      <trkpt lat=""59.78363"" lon=""17.78653"">
        <ele>30.6</ele>
      </trkpt>
      <trkpt lat=""59.78341"" lon=""17.78643"">
        <ele>30.1</ele>
      </trkpt>
      <trkpt lat=""59.78319"" lon=""17.78638"">
        <ele>29.8</ele>
      </trkpt>
      <trkpt lat=""59.78293"" lon=""17.78635"">
        <ele>29.5</ele>
      </trkpt>
      <trkpt lat=""59.78275"" lon=""17.78629"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.78275"" lon=""17.78629"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.78266"" lon=""17.78624"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.78257"" lon=""17.78618"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.78244"" lon=""17.78609"">
        <ele>29.2</ele>
      </trkpt>
      <trkpt lat=""59.78224"" lon=""17.78592"">
        <ele>28.9</ele>
      </trkpt>
      <trkpt lat=""59.78208"" lon=""17.78579"">
        <ele>28.6</ele>
      </trkpt>
      <trkpt lat=""59.78186"" lon=""17.7856"">
        <ele>28.3</ele>
      </trkpt>
      <trkpt lat=""59.78166"" lon=""17.78543"">
        <ele>28.0</ele>
      </trkpt>
      <trkpt lat=""59.78139"" lon=""17.78518"">
        <ele>27.7</ele>
      </trkpt>
      <trkpt lat=""59.78115"" lon=""17.7849499"">
        <ele>27.4</ele>
      </trkpt>
      <trkpt lat=""59.78105"" lon=""17.7848599"">
        <ele>27.5</ele>
      </trkpt>
      <trkpt lat=""59.78105"" lon=""17.78485"">
        <ele>27.5</ele>
      </trkpt>
      <trkpt lat=""59.78098"" lon=""17.78479"">
        <ele>27.5</ele>
      </trkpt>
      <trkpt lat=""59.7808"" lon=""17.7846"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.78067"" lon=""17.78446"">
        <ele>27.9</ele>
      </trkpt>
      <trkpt lat=""59.78052"" lon=""17.78433"">
        <ele>27.9</ele>
      </trkpt>
      <trkpt lat=""59.78029"" lon=""17.78416"">
        <ele>27.4</ele>
      </trkpt>
      <trkpt lat=""59.78015"" lon=""17.78406"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.77993"" lon=""17.7839199"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.77971"" lon=""17.78378"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.77949"" lon=""17.78363"">
        <ele>25.0</ele>
      </trkpt>
      <trkpt lat=""59.77936"" lon=""17.78352"">
        <ele>24.6</ele>
      </trkpt>
      <trkpt lat=""59.77923"" lon=""17.7834"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.77911"" lon=""17.78327"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.77896"" lon=""17.78309"">
        <ele>24.8</ele>
      </trkpt>
      <trkpt lat=""59.77886"" lon=""17.78294"">
        <ele>25.1</ele>
      </trkpt>
      <trkpt lat=""59.77873"" lon=""17.78275"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.77861"" lon=""17.78253"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.77852"" lon=""17.78237"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.77843"" lon=""17.7822"">
        <ele>26.4</ele>
      </trkpt>
      <trkpt lat=""59.77832"" lon=""17.7819499"">
        <ele>26.7</ele>
      </trkpt>
      <trkpt lat=""59.77818"" lon=""17.7816"">
        <ele>27.1</ele>
      </trkpt>
      <trkpt lat=""59.77814"" lon=""17.7815"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.77814"" lon=""17.78149"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.7781"" lon=""17.7814"">
        <ele>27.3</ele>
      </trkpt>
      <trkpt lat=""59.77802"" lon=""17.78119"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.77796"" lon=""17.78105"">
        <ele>27.7</ele>
      </trkpt>
      <trkpt lat=""59.77792"" lon=""17.78095"">
        <ele>27.9</ele>
      </trkpt>
      <trkpt lat=""59.77792"" lon=""17.78094"">
        <ele>27.9</ele>
      </trkpt>
      <trkpt lat=""59.77784"" lon=""17.78075"">
        <ele>28.1</ele>
      </trkpt>
      <trkpt lat=""59.77782"" lon=""17.7807"">
        <ele>28.2</ele>
      </trkpt>
      <trkpt lat=""59.77766"" lon=""17.78033"">
        <ele>28.6</ele>
      </trkpt>
      <trkpt lat=""59.7775"" lon=""17.7799799"">
        <ele>29.1</ele>
      </trkpt>
      <trkpt lat=""59.77732"" lon=""17.77962"">
        <ele>30.2</ele>
      </trkpt>
      <trkpt lat=""59.77716"" lon=""17.77933"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.77701"" lon=""17.77906"">
        <ele>31.7</ele>
      </trkpt>
      <trkpt lat=""59.77674"" lon=""17.77863"">
        <ele>32.4</ele>
      </trkpt>
      <trkpt lat=""59.77651"" lon=""17.7783"">
        <ele>32.6</ele>
      </trkpt>
      <trkpt lat=""59.77624"" lon=""17.77793"">
        <ele>33.2</ele>
      </trkpt>
      <trkpt lat=""59.7759"" lon=""17.77744"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.77558"" lon=""17.7769799"">
        <ele>35.8</ele>
      </trkpt>
      <trkpt lat=""59.77517"" lon=""17.77639"">
        <ele>37.9</ele>
      </trkpt>
      <trkpt lat=""59.77483"" lon=""17.7759"">
        <ele>40.2</ele>
      </trkpt>
      <trkpt lat=""59.77462"" lon=""17.77558"">
        <ele>41.2</ele>
      </trkpt>
      <trkpt lat=""59.77429"" lon=""17.77513"">
        <ele>41.4</ele>
      </trkpt>
      <trkpt lat=""59.77427"" lon=""17.7750999"">
        <ele>41.3</ele>
      </trkpt>
      <trkpt lat=""59.77413"" lon=""17.7749"">
        <ele>40.9</ele>
      </trkpt>
      <trkpt lat=""59.77379"" lon=""17.77443"">
        <ele>39.0</ele>
      </trkpt>
      <trkpt lat=""59.77366"" lon=""17.77427"">
        <ele>38.2</ele>
      </trkpt>
      <trkpt lat=""59.77366"" lon=""17.77426"">
        <ele>38.2</ele>
      </trkpt>
      <trkpt lat=""59.77357"" lon=""17.77414"">
        <ele>37.7</ele>
      </trkpt>
      <trkpt lat=""59.77334"" lon=""17.77387"">
        <ele>36.4</ele>
      </trkpt>
      <trkpt lat=""59.77316"" lon=""17.77365"">
        <ele>36.5</ele>
      </trkpt>
      <trkpt lat=""59.77291"" lon=""17.77339"">
        <ele>36.9</ele>
      </trkpt>
      <trkpt lat=""59.77259"" lon=""17.77309"">
        <ele>38.4</ele>
      </trkpt>
      <trkpt lat=""59.77235"" lon=""17.77283"">
        <ele>40.2</ele>
      </trkpt>
      <trkpt lat=""59.77221"" lon=""17.77265"">
        <ele>41.3</ele>
      </trkpt>
      <trkpt lat=""59.77204"" lon=""17.7724"">
        <ele>42.4</ele>
      </trkpt>
      <trkpt lat=""59.77174"" lon=""17.77194"">
        <ele>43.5</ele>
      </trkpt>
      <trkpt lat=""59.77146"" lon=""17.77148"">
        <ele>45.4</ele>
      </trkpt>
      <trkpt lat=""59.77131"" lon=""17.77128"">
        <ele>46.4</ele>
      </trkpt>
      <trkpt lat=""59.77114"" lon=""17.77106"">
        <ele>47.5</ele>
      </trkpt>
      <trkpt lat=""59.771"" lon=""17.77092"">
        <ele>48.3</ele>
      </trkpt>
      <trkpt lat=""59.77085"" lon=""17.7707799"">
        <ele>49.0</ele>
      </trkpt>
      <trkpt lat=""59.77065"" lon=""17.77063"">
        <ele>49.3</ele>
      </trkpt>
      <trkpt lat=""59.77043"" lon=""17.77048"">
        <ele>49.6</ele>
      </trkpt>
      <trkpt lat=""59.77021"" lon=""17.77035"">
        <ele>50.0</ele>
      </trkpt>
      <trkpt lat=""59.77002"" lon=""17.77026"">
        <ele>50.4</ele>
      </trkpt>
      <trkpt lat=""59.76988"" lon=""17.7702199"">
        <ele>50.5</ele>
      </trkpt>
      <trkpt lat=""59.76967"" lon=""17.77019"">
        <ele>50.5</ele>
      </trkpt>
      <trkpt lat=""59.76909"" lon=""17.77013"">
        <ele>50.5</ele>
      </trkpt>
      <trkpt lat=""59.76899"" lon=""17.77009"">
        <ele>50.3</ele>
      </trkpt>
      <trkpt lat=""59.76882"" lon=""17.77002"">
        <ele>49.8</ele>
      </trkpt>
      <trkpt lat=""59.76862"" lon=""17.76991"">
        <ele>48.8</ele>
      </trkpt>
      <trkpt lat=""59.76839"" lon=""17.76976"">
        <ele>47.4</ele>
      </trkpt>
      <trkpt lat=""59.76838"" lon=""17.76976"">
        <ele>47.4</ele>
      </trkpt>
      <trkpt lat=""59.76799"" lon=""17.76951"">
        <ele>43.9</ele>
      </trkpt>
      <trkpt lat=""59.7678"" lon=""17.76937"">
        <ele>42.0</ele>
      </trkpt>
      <trkpt lat=""59.76766"" lon=""17.76926"">
        <ele>40.6</ele>
      </trkpt>
      <trkpt lat=""59.76748"" lon=""17.7691"">
        <ele>38.7</ele>
      </trkpt>
      <trkpt lat=""59.76725"" lon=""17.76887"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.76683"" lon=""17.76842"">
        <ele>35.5</ele>
      </trkpt>
      <trkpt lat=""59.76631"" lon=""17.76786"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.76591"" lon=""17.76745"">
        <ele>38.1</ele>
      </trkpt>
      <trkpt lat=""59.76535"" lon=""17.76686"">
        <ele>36.0</ele>
      </trkpt>
      <trkpt lat=""59.76506"" lon=""17.76653"">
        <ele>34.6</ele>
      </trkpt>
      <trkpt lat=""59.76486"" lon=""17.76626"">
        <ele>34.7</ele>
      </trkpt>
      <trkpt lat=""59.7647"" lon=""17.7659999"">
        <ele>34.7</ele>
      </trkpt>
      <trkpt lat=""59.76453"" lon=""17.76566"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.76418"" lon=""17.76501"">
        <ele>33.1</ele>
      </trkpt>
      <trkpt lat=""59.76397"" lon=""17.76466"">
        <ele>33.2</ele>
      </trkpt>
      <trkpt lat=""59.76385"" lon=""17.76447"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.76369"" lon=""17.76425"">
        <ele>33.1</ele>
      </trkpt>
      <trkpt lat=""59.76347"" lon=""17.76399"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.76321"" lon=""17.76371"">
        <ele>32.1</ele>
      </trkpt>
      <trkpt lat=""59.76301"" lon=""17.76351"">
        <ele>31.6</ele>
      </trkpt>
      <trkpt lat=""59.76285"" lon=""17.76338"">
        <ele>31.2</ele>
      </trkpt>
      <trkpt lat=""59.76277"" lon=""17.76331"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.76257"" lon=""17.7631799"">
        <ele>30.6</ele>
      </trkpt>
      <trkpt lat=""59.76204"" lon=""17.76287"">
        <ele>29.5</ele>
      </trkpt>
      <trkpt lat=""59.76189"" lon=""17.76278"">
        <ele>29.1</ele>
      </trkpt>
      <trkpt lat=""59.76168"" lon=""17.76267"">
        <ele>28.6</ele>
      </trkpt>
      <trkpt lat=""59.76153"" lon=""17.7626199"">
        <ele>28.4</ele>
      </trkpt>
      <trkpt lat=""59.7614"" lon=""17.76261"">
        <ele>28.1</ele>
      </trkpt>
      <trkpt lat=""59.76116"" lon=""17.7626"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.76104"" lon=""17.76261"">
        <ele>27.3</ele>
      </trkpt>
      <trkpt lat=""59.76092"" lon=""17.76264"">
        <ele>27.0</ele>
      </trkpt>
      <trkpt lat=""59.76077"" lon=""17.76272"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.76064"" lon=""17.76281"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.76055"" lon=""17.76288"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.76051"" lon=""17.76291"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.76018"" lon=""17.76319"">
        <ele>27.0</ele>
      </trkpt>
      <trkpt lat=""59.76002"" lon=""17.76331"">
        <ele>27.0</ele>
      </trkpt>
      <trkpt lat=""59.75989"" lon=""17.76338"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.75976"" lon=""17.7634"">
        <ele>28.3</ele>
      </trkpt>
      <trkpt lat=""59.75964"" lon=""17.7633699"">
        <ele>29.1</ele>
      </trkpt>
      <trkpt lat=""59.75948"" lon=""17.76326"">
        <ele>30.1</ele>
      </trkpt>
      <trkpt lat=""59.75936"" lon=""17.76313"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.75928"" lon=""17.76301"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.75926"" lon=""17.76295"">
        <ele>31.1</ele>
      </trkpt>
      <trkpt lat=""59.75921"" lon=""17.76284"">
        <ele>31.2</ele>
      </trkpt>
      <trkpt lat=""59.75916"" lon=""17.7627099"">
        <ele>31.3</ele>
      </trkpt>
      <trkpt lat=""59.75915"" lon=""17.76266"">
        <ele>31.2</ele>
      </trkpt>
      <trkpt lat=""59.7591"" lon=""17.7624299"">
        <ele>31.1</ele>
      </trkpt>
      <trkpt lat=""59.7591"" lon=""17.76241"">
        <ele>31.0</ele>
      </trkpt>
      <trkpt lat=""59.75907"" lon=""17.76218"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.75905"" lon=""17.762"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.75904"" lon=""17.76186"">
        <ele>30.2</ele>
      </trkpt>
      <trkpt lat=""59.75903"" lon=""17.76171"">
        <ele>29.9</ele>
      </trkpt>
      <trkpt lat=""59.75901"" lon=""17.76157"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.759"" lon=""17.76153"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.75898"" lon=""17.76134"">
        <ele>31.9</ele>
      </trkpt>
      <trkpt lat=""59.75897"" lon=""17.7613"">
        <ele>32.2</ele>
      </trkpt>
      <trkpt lat=""59.75894"" lon=""17.76111"">
        <ele>33.4</ele>
      </trkpt>
      <trkpt lat=""59.75891"" lon=""17.76098"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.75886"" lon=""17.76084"">
        <ele>35.3</ele>
      </trkpt>
      <trkpt lat=""59.75879"" lon=""17.76072"">
        <ele>36.2</ele>
      </trkpt>
      <trkpt lat=""59.75869"" lon=""17.76059"">
        <ele>37.2</ele>
      </trkpt>
      <trkpt lat=""59.75861"" lon=""17.76053"">
        <ele>37.9</ele>
      </trkpt>
      <trkpt lat=""59.75854"" lon=""17.76049"">
        <ele>38.3</ele>
      </trkpt>
      <trkpt lat=""59.75842"" lon=""17.76047"">
        <ele>38.8</ele>
      </trkpt>
      <trkpt lat=""59.75832"" lon=""17.76047"">
        <ele>39.0</ele>
      </trkpt>
      <trkpt lat=""59.75821"" lon=""17.76051"">
        <ele>38.4</ele>
      </trkpt>
      <trkpt lat=""59.75813"" lon=""17.76058"">
        <ele>37.7</ele>
      </trkpt>
      <trkpt lat=""59.75805"" lon=""17.76066"">
        <ele>36.9</ele>
      </trkpt>
      <trkpt lat=""59.75799"" lon=""17.76076"">
        <ele>36.1</ele>
      </trkpt>
      <trkpt lat=""59.75783"" lon=""17.76109"">
        <ele>33.8</ele>
      </trkpt>
      <trkpt lat=""59.75765"" lon=""17.76144"">
        <ele>31.9</ele>
      </trkpt>
      <trkpt lat=""59.75754"" lon=""17.7616"">
        <ele>31.2</ele>
      </trkpt>
      <trkpt lat=""59.75737"" lon=""17.7617699"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.7573"" lon=""17.76183"">
        <ele>30.5</ele>
      </trkpt>
      <trkpt lat=""59.75717"" lon=""17.76192"">
        <ele>30.1</ele>
      </trkpt>
      <trkpt lat=""59.75702"" lon=""17.76198"">
        <ele>29.6</ele>
      </trkpt>
      <trkpt lat=""59.75694"" lon=""17.76198"">
        <ele>29.4</ele>
      </trkpt>
      <trkpt lat=""59.75682"" lon=""17.76197"">
        <ele>28.9</ele>
      </trkpt>
      <trkpt lat=""59.7565"" lon=""17.76192"">
        <ele>28.0</ele>
      </trkpt>
      <trkpt lat=""59.75624"" lon=""17.76189"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.75593"" lon=""17.7618699"">
        <ele>27.1</ele>
      </trkpt>
      <trkpt lat=""59.75556"" lon=""17.76189"">
        <ele>26.7</ele>
      </trkpt>
      <trkpt lat=""59.75504"" lon=""17.76194"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.75485"" lon=""17.76194"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.75431"" lon=""17.7619"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.75414"" lon=""17.76189"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.75388"" lon=""17.76191"">
        <ele>29.2</ele>
      </trkpt>
      <trkpt lat=""59.75366"" lon=""17.76194"">
        <ele>30.4</ele>
      </trkpt>
      <trkpt lat=""59.75338"" lon=""17.76199"">
        <ele>31.8</ele>
      </trkpt>
      <trkpt lat=""59.75294"" lon=""17.76207"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.75271"" lon=""17.76212"">
        <ele>32.1</ele>
      </trkpt>
      <trkpt lat=""59.75248"" lon=""17.76217"">
        <ele>32.3</ele>
      </trkpt>
      <trkpt lat=""59.75236"" lon=""17.76223"">
        <ele>32.5</ele>
      </trkpt>
      <trkpt lat=""59.75219"" lon=""17.76232"">
        <ele>32.6</ele>
      </trkpt>
      <trkpt lat=""59.75201"" lon=""17.76241"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.7519"" lon=""17.76245"">
        <ele>32.7</ele>
      </trkpt>
      <trkpt lat=""59.75182"" lon=""17.76246"">
        <ele>32.9</ele>
      </trkpt>
      <trkpt lat=""59.75166"" lon=""17.7624299"">
        <ele>33.5</ele>
      </trkpt>
      <trkpt lat=""59.75162"" lon=""17.7624"">
        <ele>33.4</ele>
      </trkpt>
      <trkpt lat=""59.7515"" lon=""17.7623399"">
        <ele>33.1</ele>
      </trkpt>
      <trkpt lat=""59.7513"" lon=""17.76221"">
        <ele>32.6</ele>
      </trkpt>
      <trkpt lat=""59.75106"" lon=""17.76201"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.75101"" lon=""17.76197"">
        <ele>31.9</ele>
      </trkpt>
      <trkpt lat=""59.75093"" lon=""17.76188"">
        <ele>31.7</ele>
      </trkpt>
      <trkpt lat=""59.75084"" lon=""17.76178"">
        <ele>31.5</ele>
      </trkpt>
      <trkpt lat=""59.75067"" lon=""17.76155"">
        <ele>31.4</ele>
      </trkpt>
      <trkpt lat=""59.75027"" lon=""17.76101"">
        <ele>30.5</ele>
      </trkpt>
      <trkpt lat=""59.75009"" lon=""17.76079"">
        <ele>29.7</ele>
      </trkpt>
      <trkpt lat=""59.75"" lon=""17.7607"">
        <ele>29.2</ele>
      </trkpt>
      <trkpt lat=""59.74986"" lon=""17.76061"">
        <ele>28.0</ele>
      </trkpt>
      <trkpt lat=""59.74979"" lon=""17.76059"">
        <ele>27.5</ele>
      </trkpt>
      <trkpt lat=""59.74968"" lon=""17.76058"">
        <ele>26.5</ele>
      </trkpt>
      <trkpt lat=""59.74955"" lon=""17.7606"">
        <ele>25.4</ele>
      </trkpt>
      <trkpt lat=""59.74947"" lon=""17.76063"">
        <ele>24.6</ele>
      </trkpt>
      <trkpt lat=""59.74939"" lon=""17.76067"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.74914"" lon=""17.76081"">
        <ele>21.9</ele>
      </trkpt>
      <trkpt lat=""59.74902"" lon=""17.76087"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.74874"" lon=""17.761"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.74858"" lon=""17.76105"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.74842"" lon=""17.76106"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.74824"" lon=""17.76104"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.74757"" lon=""17.76085"">
        <ele>18.2</ele>
      </trkpt>
      <trkpt lat=""59.74687"" lon=""17.76067"">
        <ele>18.1</ele>
      </trkpt>
      <trkpt lat=""59.7467"" lon=""17.76063"">
        <ele>18.2</ele>
      </trkpt>
      <trkpt lat=""59.74654"" lon=""17.76063"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.74635"" lon=""17.7606499"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.74617"" lon=""17.76067"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.74593"" lon=""17.76073"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.74573"" lon=""17.7608"">
        <ele>25.5</ele>
      </trkpt>
      <trkpt lat=""59.74551"" lon=""17.7609"">
        <ele>28.4</ele>
      </trkpt>
      <trkpt lat=""59.74509"" lon=""17.7611199"">
        <ele>33.1</ele>
      </trkpt>
      <trkpt lat=""59.74428"" lon=""17.76158"">
        <ele>33.4</ele>
      </trkpt>
      <trkpt lat=""59.74398"" lon=""17.76174"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.74383"" lon=""17.76181"">
        <ele>32.5</ele>
      </trkpt>
      <trkpt lat=""59.74368"" lon=""17.76183"">
        <ele>32.6</ele>
      </trkpt>
      <trkpt lat=""59.74353"" lon=""17.76182"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.74339"" lon=""17.76178"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.74324"" lon=""17.7617"">
        <ele>33.6</ele>
      </trkpt>
      <trkpt lat=""59.74313"" lon=""17.76161"">
        <ele>33.7</ele>
      </trkpt>
      <trkpt lat=""59.74304"" lon=""17.76152"">
        <ele>33.6</ele>
      </trkpt>
      <trkpt lat=""59.74303"" lon=""17.76151"">
        <ele>33.6</ele>
      </trkpt>
      <trkpt lat=""59.74284"" lon=""17.76124"">
        <ele>33.4</ele>
      </trkpt>
      <trkpt lat=""59.74269"" lon=""17.7610199"">
        <ele>33.0</ele>
      </trkpt>
      <trkpt lat=""59.74215"" lon=""17.76013"">
        <ele>30.6</ele>
      </trkpt>
      <trkpt lat=""59.74167"" lon=""17.75938"">
        <ele>29.5</ele>
      </trkpt>
      <trkpt lat=""59.74153"" lon=""17.75918"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.74145"" lon=""17.75909"">
        <ele>28.5</ele>
      </trkpt>
      <trkpt lat=""59.74136"" lon=""17.75898"">
        <ele>27.9</ele>
      </trkpt>
      <trkpt lat=""59.74125"" lon=""17.75891"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.74109"" lon=""17.75883"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.74075"" lon=""17.75873"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.74061"" lon=""17.7586799"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.74061"" lon=""17.7586799"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.7404"" lon=""17.75862"">
        <ele>23.8</ele>
      </trkpt>
      <trkpt lat=""59.74021"" lon=""17.75853"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.73994"" lon=""17.75836"">
        <ele>23.1</ele>
      </trkpt>
      <trkpt lat=""59.7396"" lon=""17.7581"">
        <ele>22.6</ele>
      </trkpt>
      <trkpt lat=""59.73903"" lon=""17.75771"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.73903"" lon=""17.75771"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.73915"" lon=""17.75728"">
        <ele>20.4</ele>
      </trkpt>
      <trkpt lat=""59.73923"" lon=""17.75696"">
        <ele>19.8</ele>
      </trkpt>
      <trkpt lat=""59.7393"" lon=""17.7566099"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.73953"" lon=""17.75547"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.73963"" lon=""17.75496"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.73986"" lon=""17.75357"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.73993"" lon=""17.75311"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.73998"" lon=""17.75281"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.74002"" lon=""17.75246"">
        <ele>20.1</ele>
      </trkpt>
      <trkpt lat=""59.74005"" lon=""17.75216"">
        <ele>20.2</ele>
      </trkpt>
      <trkpt lat=""59.74008"" lon=""17.75174"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.74011"" lon=""17.75137"">
        <ele>20.1</ele>
      </trkpt>
      <trkpt lat=""59.74016"" lon=""17.7498"">
        <ele>19.5</ele>
      </trkpt>
      <trkpt lat=""59.74017"" lon=""17.74909"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.74018"" lon=""17.74857"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.74017"" lon=""17.74777"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.74017"" lon=""17.74735"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.74017"" lon=""17.747"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.74018"" lon=""17.74669"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.7402"" lon=""17.74635"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.74023"" lon=""17.74585"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.74023"" lon=""17.74558"">
        <ele>18.5</ele>
      </trkpt>
      <trkpt lat=""59.74022"" lon=""17.7452599"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.74017"" lon=""17.74465"">
        <ele>18.0</ele>
      </trkpt>
      <trkpt lat=""59.74012"" lon=""17.74409"">
        <ele>17.4</ele>
      </trkpt>
      <trkpt lat=""59.74007"" lon=""17.7436599"">
        <ele>17.3</ele>
      </trkpt>
      <trkpt lat=""59.74"" lon=""17.74322"">
        <ele>17.1</ele>
      </trkpt>
      <trkpt lat=""59.73995"" lon=""17.74289"">
        <ele>17.4</ele>
      </trkpt>
      <trkpt lat=""59.73991"" lon=""17.74247"">
        <ele>17.8</ele>
      </trkpt>
      <trkpt lat=""59.73982"" lon=""17.74162"">
        <ele>18.5</ele>
      </trkpt>
      <trkpt lat=""59.73977"" lon=""17.74119"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.73971"" lon=""17.74068"">
        <ele>19.8</ele>
      </trkpt>
      <trkpt lat=""59.73966"" lon=""17.74018"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.73962"" lon=""17.73994"">
        <ele>20.2</ele>
      </trkpt>
      <trkpt lat=""59.73956"" lon=""17.73968"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.73945"" lon=""17.7392499"">
        <ele>18.1</ele>
      </trkpt>
      <trkpt lat=""59.7394"" lon=""17.739"">
        <ele>17.7</ele>
      </trkpt>
      <trkpt lat=""59.73937"" lon=""17.7388"">
        <ele>17.5</ele>
      </trkpt>
      <trkpt lat=""59.73933"" lon=""17.73839"">
        <ele>17.2</ele>
      </trkpt>
      <trkpt lat=""59.73926"" lon=""17.73786"">
        <ele>16.7</ele>
      </trkpt>
      <trkpt lat=""59.73922"" lon=""17.73752"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.73921"" lon=""17.73727"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.73919"" lon=""17.73687"">
        <ele>16.2</ele>
      </trkpt>
      <trkpt lat=""59.73919"" lon=""17.73617"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.73916"" lon=""17.73569"">
        <ele>17.0</ele>
      </trkpt>
      <trkpt lat=""59.73911"" lon=""17.7347"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.73907"" lon=""17.73406"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.73905"" lon=""17.73386"">
        <ele>16.7</ele>
      </trkpt>
      <trkpt lat=""59.739"" lon=""17.73361"">
        <ele>16.6</ele>
      </trkpt>
      <trkpt lat=""59.73889"" lon=""17.73324"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.73861"" lon=""17.73235"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.7383"" lon=""17.73139"">
        <ele>17.9</ele>
      </trkpt>
      <trkpt lat=""59.73794"" lon=""17.73026"">
        <ele>19.9</ele>
      </trkpt>
      <trkpt lat=""59.73788"" lon=""17.73004"">
        <ele>20.2</ele>
      </trkpt>
      <trkpt lat=""59.73784"" lon=""17.7299"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.7378"" lon=""17.7297"">
        <ele>20.4</ele>
      </trkpt>
      <trkpt lat=""59.73776"" lon=""17.7295"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.73768"" lon=""17.72891"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.73761"" lon=""17.72863"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.73753"" lon=""17.72829"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.73736"" lon=""17.72757"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.73721"" lon=""17.72692"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.73715"" lon=""17.72662"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.73708"" lon=""17.72618"">
        <ele>18.2</ele>
      </trkpt>
      <trkpt lat=""59.7369"" lon=""17.7251"">
        <ele>16.5</ele>
      </trkpt>
      <trkpt lat=""59.73681"" lon=""17.72462"">
        <ele>16.3</ele>
      </trkpt>
      <trkpt lat=""59.73671"" lon=""17.72411"">
        <ele>16.3</ele>
      </trkpt>
      <trkpt lat=""59.73666"" lon=""17.72382"">
        <ele>16.0</ele>
      </trkpt>
      <trkpt lat=""59.73656"" lon=""17.72312"">
        <ele>16.7</ele>
      </trkpt>
      <trkpt lat=""59.73651"" lon=""17.72288"">
        <ele>17.4</ele>
      </trkpt>
      <trkpt lat=""59.73641"" lon=""17.72257"">
        <ele>18.2</ele>
      </trkpt>
      <trkpt lat=""59.73632"" lon=""17.72232"">
        <ele>18.5</ele>
      </trkpt>
      <trkpt lat=""59.73617"" lon=""17.72195"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.73589"" lon=""17.7212299"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.73571"" lon=""17.72073"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.73539"" lon=""17.71983"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.73521"" lon=""17.71931"">
        <ele>20.2</ele>
      </trkpt>
      <trkpt lat=""59.73515"" lon=""17.7191"">
        <ele>19.9</ele>
      </trkpt>
      <trkpt lat=""59.7351"" lon=""17.71886"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.73504"" lon=""17.71853"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.73498"" lon=""17.71816"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.73493"" lon=""17.71772"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.73484"" lon=""17.71638"">
        <ele>19.6</ele>
      </trkpt>
      <trkpt lat=""59.73484"" lon=""17.71617"">
        <ele>20.2</ele>
      </trkpt>
      <trkpt lat=""59.73485"" lon=""17.71599"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.73488"" lon=""17.71582"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.73492"" lon=""17.71568"">
        <ele>22.5</ele>
      </trkpt>
      <trkpt lat=""59.73499"" lon=""17.71553"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.73508"" lon=""17.71543"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.73522"" lon=""17.71531"">
        <ele>25.1</ele>
      </trkpt>
      <trkpt lat=""59.73547"" lon=""17.71515"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.73558"" lon=""17.71503"">
        <ele>26.4</ele>
      </trkpt>
      <trkpt lat=""59.73565"" lon=""17.71491"">
        <ele>26.4</ele>
      </trkpt>
      <trkpt lat=""59.73571"" lon=""17.7147599"">
        <ele>26.4</ele>
      </trkpt>
      <trkpt lat=""59.73574"" lon=""17.71458"">
        <ele>26.2</ele>
      </trkpt>
      <trkpt lat=""59.73577"" lon=""17.71435"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.73578"" lon=""17.71412"">
        <ele>25.8</ele>
      </trkpt>
      <trkpt lat=""59.73576"" lon=""17.71378"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.73569"" lon=""17.71332"">
        <ele>25.3</ele>
      </trkpt>
      <trkpt lat=""59.7356"" lon=""17.7126899"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.73556"" lon=""17.7125"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.73553"" lon=""17.71242"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.73546"" lon=""17.71233"">
        <ele>25.3</ele>
      </trkpt>
      <trkpt lat=""59.73535"" lon=""17.71224"">
        <ele>24.8</ele>
      </trkpt>
      <trkpt lat=""59.7351"" lon=""17.71206"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.73488"" lon=""17.71195"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.73478"" lon=""17.71187"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.7347"" lon=""17.71174"">
        <ele>19.8</ele>
      </trkpt>
      <trkpt lat=""59.73464"" lon=""17.7116"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.73462"" lon=""17.7114699"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.73461"" lon=""17.71127"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.7346"" lon=""17.71012"">
        <ele>20.2</ele>
      </trkpt>
      <trkpt lat=""59.7346"" lon=""17.70925"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.73461"" lon=""17.70884"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.7346"" lon=""17.70865"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.73458"" lon=""17.70834"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.73452"" lon=""17.70757"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.7345"" lon=""17.70733"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.7345"" lon=""17.70704"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.7345"" lon=""17.70652"">
        <ele>21.4</ele>
      </trkpt>
      <trkpt lat=""59.73449"" lon=""17.70635"">
        <ele>21.5</ele>
      </trkpt>
      <trkpt lat=""59.73446"" lon=""17.70617"">
        <ele>21.4</ele>
      </trkpt>
      <trkpt lat=""59.73441"" lon=""17.7058399"">
        <ele>21.2</ele>
      </trkpt>
      <trkpt lat=""59.73439"" lon=""17.70569"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.73433"" lon=""17.70499"">
        <ele>20.7</ele>
      </trkpt>
      <trkpt lat=""59.7343"" lon=""17.70454"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.73428"" lon=""17.70424"">
        <ele>19.0</ele>
      </trkpt>
      <trkpt lat=""59.73427"" lon=""17.70401"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.73428"" lon=""17.70374"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.73429"" lon=""17.70354"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.73434"" lon=""17.7032"">
        <ele>20.1</ele>
      </trkpt>
      <trkpt lat=""59.73435"" lon=""17.70314"">
        <ele>20.4</ele>
      </trkpt>
      <trkpt lat=""59.73437"" lon=""17.70291"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.73439"" lon=""17.70267"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.73441"" lon=""17.70234"">
        <ele>22.5</ele>
      </trkpt>
      <trkpt lat=""59.73443"" lon=""17.70179"">
        <ele>23.3</ele>
      </trkpt>
      <trkpt lat=""59.73442"" lon=""17.7015"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.73442"" lon=""17.70119"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.73437"" lon=""17.70053"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.73432"" lon=""17.69979"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.73424"" lon=""17.69857"">
        <ele>21.9</ele>
      </trkpt>
      <trkpt lat=""59.73422"" lon=""17.69847"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.73419"" lon=""17.69839"">
        <ele>21.3</ele>
      </trkpt>
      <trkpt lat=""59.7341"" lon=""17.69831"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.7341"" lon=""17.69831"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.73412"" lon=""17.69812"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.73415"" lon=""17.6978"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.73416"" lon=""17.69742"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.73414"" lon=""17.69588"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.73411"" lon=""17.69405"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.7341"" lon=""17.69341"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.73407"" lon=""17.69273"">
        <ele>19.6</ele>
      </trkpt>
      <trkpt lat=""59.73404"" lon=""17.69219"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.73402"" lon=""17.69174"">
        <ele>18.2</ele>
      </trkpt>
      <trkpt lat=""59.73394"" lon=""17.69053"">
        <ele>19.6</ele>
      </trkpt>
      <trkpt lat=""59.73391"" lon=""17.69007"">
        <ele>19.8</ele>
      </trkpt>
      <trkpt lat=""59.7339"" lon=""17.68975"">
        <ele>19.6</ele>
      </trkpt>
      <trkpt lat=""59.7339"" lon=""17.68919"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.7339"" lon=""17.68888"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.73392"" lon=""17.68857"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.73394"" lon=""17.68827"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.73398"" lon=""17.68798"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.73402"" lon=""17.68772"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.73409"" lon=""17.68735"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.73416"" lon=""17.68706"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.73425"" lon=""17.68673"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.73436"" lon=""17.6864"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.73443"" lon=""17.68622"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.73457"" lon=""17.68581"">
        <ele>18.4</ele>
      </trkpt>
      <trkpt lat=""59.73497"" lon=""17.68471"">
        <ele>17.2</ele>
      </trkpt>
      <trkpt lat=""59.73535"" lon=""17.68368"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.73557"" lon=""17.68309"">
        <ele>16.1</ele>
      </trkpt>
      <trkpt lat=""59.73588"" lon=""17.68225"">
        <ele>16.2</ele>
      </trkpt>
      <trkpt lat=""59.73621"" lon=""17.68134"">
        <ele>17.4</ele>
      </trkpt>
      <trkpt lat=""59.73649"" lon=""17.68057"">
        <ele>17.2</ele>
      </trkpt>
      <trkpt lat=""59.73662"" lon=""17.68019"">
        <ele>16.5</ele>
      </trkpt>
      <trkpt lat=""59.73673"" lon=""17.67986"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.73685"" lon=""17.67948"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.73713"" lon=""17.67853"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.73755"" lon=""17.67706"">
        <ele>17.2</ele>
      </trkpt>
      <trkpt lat=""59.73789"" lon=""17.67592"">
        <ele>18.0</ele>
      </trkpt>
      <trkpt lat=""59.73809"" lon=""17.67518"">
        <ele>18.4</ele>
      </trkpt>
      <trkpt lat=""59.73815"" lon=""17.67495"">
        <ele>18.6</ele>
      </trkpt>
      <trkpt lat=""59.73821"" lon=""17.67465"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.73828"" lon=""17.67426"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.73834"" lon=""17.6737499"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.73843"" lon=""17.67286"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.73849"" lon=""17.67233"">
        <ele>23.0</ele>
      </trkpt>
      <trkpt lat=""59.73849"" lon=""17.67232"">
        <ele>23.0</ele>
      </trkpt>
      <trkpt lat=""59.73851"" lon=""17.6722"">
        <ele>23.2</ele>
      </trkpt>
      <trkpt lat=""59.73858"" lon=""17.67181"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.73879"" lon=""17.67094"">
        <ele>23.8</ele>
      </trkpt>
      <trkpt lat=""59.7391"" lon=""17.66987"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.73947"" lon=""17.66876"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.73979"" lon=""17.66787"">
        <ele>24.6</ele>
      </trkpt>
      <trkpt lat=""59.73992"" lon=""17.66753"">
        <ele>24.5</ele>
      </trkpt>
      <trkpt lat=""59.74004"" lon=""17.66729"">
        <ele>24.5</ele>
      </trkpt>
      <trkpt lat=""59.74019"" lon=""17.66704"">
        <ele>24.8</ele>
      </trkpt>
      <trkpt lat=""59.74025"" lon=""17.66698"">
        <ele>25.1</ele>
      </trkpt>
      <trkpt lat=""59.74053"" lon=""17.66665"">
        <ele>26.4</ele>
      </trkpt>
      <trkpt lat=""59.74079"" lon=""17.6664"">
        <ele>27.7</ele>
      </trkpt>
      <trkpt lat=""59.74099"" lon=""17.66622"">
        <ele>29.2</ele>
      </trkpt>
      <trkpt lat=""59.7416"" lon=""17.66586"">
        <ele>35.3</ele>
      </trkpt>
      <trkpt lat=""59.74225"" lon=""17.66536"">
        <ele>37.8</ele>
      </trkpt>
      <trkpt lat=""59.74259"" lon=""17.66504"">
        <ele>38.5</ele>
      </trkpt>
      <trkpt lat=""59.7426"" lon=""17.66503"">
        <ele>38.4</ele>
      </trkpt>
      <trkpt lat=""59.74282"" lon=""17.6647399"">
        <ele>36.9</ele>
      </trkpt>
      <trkpt lat=""59.74304"" lon=""17.6643599"">
        <ele>35.5</ele>
      </trkpt>
      <trkpt lat=""59.74326"" lon=""17.66391"">
        <ele>34.3</ele>
      </trkpt>
      <trkpt lat=""59.74351"" lon=""17.66341"">
        <ele>34.0</ele>
      </trkpt>
      <trkpt lat=""59.74367"" lon=""17.66313"">
        <ele>33.5</ele>
      </trkpt>
      <trkpt lat=""59.74384"" lon=""17.6628599"">
        <ele>33.0</ele>
      </trkpt>
      <trkpt lat=""59.74404"" lon=""17.66254"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.74419"" lon=""17.6622999"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.74432"" lon=""17.66207"">
        <ele>35.2</ele>
      </trkpt>
      <trkpt lat=""59.74445"" lon=""17.66182"">
        <ele>37.1</ele>
      </trkpt>
      <trkpt lat=""59.74464"" lon=""17.66135"">
        <ele>40.3</ele>
      </trkpt>
      <trkpt lat=""59.74479"" lon=""17.66091"">
        <ele>42.7</ele>
      </trkpt>
      <trkpt lat=""59.7449"" lon=""17.66048"">
        <ele>44.1</ele>
      </trkpt>
      <trkpt lat=""59.74498"" lon=""17.66009"">
        <ele>44.8</ele>
      </trkpt>
      <trkpt lat=""59.74515"" lon=""17.65929"">
        <ele>46.6</ele>
      </trkpt>
      <trkpt lat=""59.74527"" lon=""17.65847"">
        <ele>47.0</ele>
      </trkpt>
      <trkpt lat=""59.74537"" lon=""17.6576099"">
        <ele>46.0</ele>
      </trkpt>
      <trkpt lat=""59.7454"" lon=""17.6573"">
        <ele>45.6</ele>
      </trkpt>
      <trkpt lat=""59.74547"" lon=""17.65707"">
        <ele>45.5</ele>
      </trkpt>
      <trkpt lat=""59.74547"" lon=""17.657"">
        <ele>45.4</ele>
      </trkpt>
      <trkpt lat=""59.74553"" lon=""17.65631"">
        <ele>44.8</ele>
      </trkpt>
      <trkpt lat=""59.74558"" lon=""17.65589"">
        <ele>44.5</ele>
      </trkpt>
      <trkpt lat=""59.74562"" lon=""17.65569"">
        <ele>44.7</ele>
      </trkpt>
      <trkpt lat=""59.74568"" lon=""17.65547"">
        <ele>45.1</ele>
      </trkpt>
      <trkpt lat=""59.74574"" lon=""17.65529"">
        <ele>45.4</ele>
      </trkpt>
      <trkpt lat=""59.74582"" lon=""17.65511"">
        <ele>45.9</ele>
      </trkpt>
      <trkpt lat=""59.74592"" lon=""17.65493"">
        <ele>46.8</ele>
      </trkpt>
      <trkpt lat=""59.74605"" lon=""17.65478"">
        <ele>48.0</ele>
      </trkpt>
      <trkpt lat=""59.74632"" lon=""17.65457"">
        <ele>49.9</ele>
      </trkpt>
      <trkpt lat=""59.74656"" lon=""17.6544199"">
        <ele>51.2</ele>
      </trkpt>
      <trkpt lat=""59.74674"" lon=""17.65424"">
        <ele>52.1</ele>
      </trkpt>
      <trkpt lat=""59.74686"" lon=""17.65417"">
        <ele>52.5</ele>
      </trkpt>
      <trkpt lat=""59.74723"" lon=""17.65396"">
        <ele>53.3</ele>
      </trkpt>
      <trkpt lat=""59.74798"" lon=""17.6535699"">
        <ele>53.7</ele>
      </trkpt>
      <trkpt lat=""59.74857"" lon=""17.65328"">
        <ele>54.1</ele>
      </trkpt>
      <trkpt lat=""59.74897"" lon=""17.65314"">
        <ele>54.3</ele>
      </trkpt>
      <trkpt lat=""59.74943"" lon=""17.65296"">
        <ele>54.5</ele>
      </trkpt>
      <trkpt lat=""59.74949"" lon=""17.65293"">
        <ele>54.5</ele>
      </trkpt>
      <trkpt lat=""59.7501"" lon=""17.65257"">
        <ele>53.9</ele>
      </trkpt>
      <trkpt lat=""59.75052"" lon=""17.65231"">
        <ele>52.5</ele>
      </trkpt>
      <trkpt lat=""59.75086"" lon=""17.65212"">
        <ele>51.5</ele>
      </trkpt>
      <trkpt lat=""59.75138"" lon=""17.65189"">
        <ele>49.7</ele>
      </trkpt>
      <trkpt lat=""59.75192"" lon=""17.65166"">
        <ele>46.5</ele>
      </trkpt>
      <trkpt lat=""59.75207"" lon=""17.65159"">
        <ele>45.4</ele>
      </trkpt>
      <trkpt lat=""59.75255"" lon=""17.6514099"">
        <ele>42.1</ele>
      </trkpt>
      <trkpt lat=""59.75304"" lon=""17.65121"">
        <ele>41.4</ele>
      </trkpt>
      <trkpt lat=""59.75353"" lon=""17.65101"">
        <ele>41.3</ele>
      </trkpt>
      <trkpt lat=""59.75366"" lon=""17.65096"">
        <ele>41.6</ele>
      </trkpt>
      <trkpt lat=""59.75403"" lon=""17.65087"">
        <ele>42.6</ele>
      </trkpt>
      <trkpt lat=""59.75469"" lon=""17.65077"">
        <ele>44.2</ele>
      </trkpt>
      <trkpt lat=""59.75486"" lon=""17.65073"">
        <ele>44.5</ele>
      </trkpt>
      <trkpt lat=""59.7552"" lon=""17.65059"">
        <ele>45.1</ele>
      </trkpt>
      <trkpt lat=""59.75529"" lon=""17.65054"">
        <ele>45.2</ele>
      </trkpt>
      <trkpt lat=""59.75577"" lon=""17.65013"">
        <ele>45.2</ele>
      </trkpt>
      <trkpt lat=""59.75601"" lon=""17.64985"">
        <ele>44.2</ele>
      </trkpt>
      <trkpt lat=""59.75661"" lon=""17.64908"">
        <ele>39.6</ele>
      </trkpt>
      <trkpt lat=""59.75734"" lon=""17.64815"">
        <ele>38.0</ele>
      </trkpt>
      <trkpt lat=""59.75828"" lon=""17.64693"">
        <ele>38.2</ele>
      </trkpt>
      <trkpt lat=""59.75855"" lon=""17.6466"">
        <ele>38.2</ele>
      </trkpt>
      <trkpt lat=""59.75866"" lon=""17.6465"">
        <ele>38.4</ele>
      </trkpt>
      <trkpt lat=""59.75882"" lon=""17.64635"">
        <ele>38.8</ele>
      </trkpt>
      <trkpt lat=""59.75905"" lon=""17.64621"">
        <ele>39.1</ele>
      </trkpt>
      <trkpt lat=""59.75917"" lon=""17.6461599"">
        <ele>39.2</ele>
      </trkpt>
      <trkpt lat=""59.75937"" lon=""17.64608"">
        <ele>39.1</ele>
      </trkpt>
      <trkpt lat=""59.75989"" lon=""17.64589"">
        <ele>38.3</ele>
      </trkpt>
      <trkpt lat=""59.76041"" lon=""17.6457"">
        <ele>37.3</ele>
      </trkpt>
      <trkpt lat=""59.76093"" lon=""17.64551"">
        <ele>36.0</ele>
      </trkpt>
      <trkpt lat=""59.76104"" lon=""17.6454999"">
        <ele>36.2</ele>
      </trkpt>
      <trkpt lat=""59.76134"" lon=""17.64548"">
        <ele>36.9</ele>
      </trkpt>
      <trkpt lat=""59.76141"" lon=""17.6454999"">
        <ele>37.0</ele>
      </trkpt>
      <trkpt lat=""59.76162"" lon=""17.64557"">
        <ele>37.6</ele>
      </trkpt>
      <trkpt lat=""59.76192"" lon=""17.64575"">
        <ele>38.5</ele>
      </trkpt>
      <trkpt lat=""59.76225"" lon=""17.64591"">
        <ele>39.5</ele>
      </trkpt>
      <trkpt lat=""59.76253"" lon=""17.64599"">
        <ele>40.0</ele>
      </trkpt>
      <trkpt lat=""59.76297"" lon=""17.64607"">
        <ele>39.6</ele>
      </trkpt>
      <trkpt lat=""59.76362"" lon=""17.64608"">
        <ele>39.7</ele>
      </trkpt>
      <trkpt lat=""59.764"" lon=""17.64611"">
        <ele>40.4</ele>
      </trkpt>
      <trkpt lat=""59.7644"" lon=""17.64619"">
        <ele>40.1</ele>
      </trkpt>
      <trkpt lat=""59.76477"" lon=""17.64634"">
        <ele>38.7</ele>
      </trkpt>
      <trkpt lat=""59.7653"" lon=""17.6465299"">
        <ele>36.5</ele>
      </trkpt>
      <trkpt lat=""59.76562"" lon=""17.64669"">
        <ele>35.5</ele>
      </trkpt>
      <trkpt lat=""59.76595"" lon=""17.64689"">
        <ele>34.5</ele>
      </trkpt>
      <trkpt lat=""59.76624"" lon=""17.64711"">
        <ele>33.8</ele>
      </trkpt>
      <trkpt lat=""59.76653"" lon=""17.64733"">
        <ele>33.2</ele>
      </trkpt>
      <trkpt lat=""59.76691"" lon=""17.64769"">
        <ele>32.8</ele>
      </trkpt>
      <trkpt lat=""59.76742"" lon=""17.64819"">
        <ele>32.2</ele>
      </trkpt>
      <trkpt lat=""59.76781"" lon=""17.64861"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.76832"" lon=""17.64914"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.76874"" lon=""17.6496299"">
        <ele>33.3</ele>
      </trkpt>
      <trkpt lat=""59.7689"" lon=""17.64986"">
        <ele>33.6</ele>
      </trkpt>
      <trkpt lat=""59.76907"" lon=""17.65017"">
        <ele>33.9</ele>
      </trkpt>
      <trkpt lat=""59.76935"" lon=""17.65083"">
        <ele>34.4</ele>
      </trkpt>
      <trkpt lat=""59.76965"" lon=""17.65161"">
        <ele>36.6</ele>
      </trkpt>
      <trkpt lat=""59.76981"" lon=""17.65202"">
        <ele>38.7</ele>
      </trkpt>
      <trkpt lat=""59.77029"" lon=""17.65323"">
        <ele>46.9</ele>
      </trkpt>
      <trkpt lat=""59.77053"" lon=""17.6537599"">
        <ele>49.5</ele>
      </trkpt>
      <trkpt lat=""59.77087"" lon=""17.65439"">
        <ele>52.2</ele>
      </trkpt>
      <trkpt lat=""59.77113"" lon=""17.6548"">
        <ele>54.1</ele>
      </trkpt>
      <trkpt lat=""59.77197"" lon=""17.65597"">
        <ele>58.2</ele>
      </trkpt>
      <trkpt lat=""59.77219"" lon=""17.65625"">
        <ele>58.1</ele>
      </trkpt>
      <trkpt lat=""59.7727"" lon=""17.65678"">
        <ele>57.4</ele>
      </trkpt>
      <trkpt lat=""59.77292"" lon=""17.65707"">
        <ele>57.0</ele>
      </trkpt>
      <trkpt lat=""59.77301"" lon=""17.65722"">
        <ele>56.8</ele>
      </trkpt>
      <trkpt lat=""59.77317"" lon=""17.65752"">
        <ele>56.6</ele>
      </trkpt>
      <trkpt lat=""59.77327"" lon=""17.65776"">
        <ele>56.5</ele>
      </trkpt>
      <trkpt lat=""59.77344"" lon=""17.6582"">
        <ele>56.4</ele>
      </trkpt>
      <trkpt lat=""59.77356"" lon=""17.65858"">
        <ele>56.8</ele>
      </trkpt>
      <trkpt lat=""59.77381"" lon=""17.65933"">
        <ele>58.4</ele>
      </trkpt>
      <trkpt lat=""59.77405"" lon=""17.65992"">
        <ele>60.0</ele>
      </trkpt>
      <trkpt lat=""59.77428"" lon=""17.6603299"">
        <ele>60.6</ele>
      </trkpt>
      <trkpt lat=""59.77442"" lon=""17.66055"">
        <ele>60.9</ele>
      </trkpt>
      <trkpt lat=""59.77469"" lon=""17.66091"">
        <ele>61.6</ele>
      </trkpt>
      <trkpt lat=""59.77493"" lon=""17.66123"">
        <ele>62.5</ele>
      </trkpt>
      <trkpt lat=""59.77513"" lon=""17.66144"">
        <ele>62.9</ele>
      </trkpt>
      <trkpt lat=""59.77549"" lon=""17.66178"">
        <ele>62.7</ele>
      </trkpt>
      <trkpt lat=""59.77608"" lon=""17.66223"">
        <ele>60.1</ele>
      </trkpt>
      <trkpt lat=""59.77649"" lon=""17.66247"">
        <ele>57.9</ele>
      </trkpt>
      <trkpt lat=""59.77682"" lon=""17.66269"">
        <ele>57.3</ele>
      </trkpt>
      <trkpt lat=""59.77708"" lon=""17.66283"">
        <ele>56.9</ele>
      </trkpt>
      <trkpt lat=""59.77751"" lon=""17.66307"">
        <ele>56.0</ele>
      </trkpt>
      <trkpt lat=""59.77817"" lon=""17.66335"">
        <ele>50.6</ele>
      </trkpt>
      <trkpt lat=""59.77846"" lon=""17.66342"">
        <ele>48.1</ele>
      </trkpt>
      <trkpt lat=""59.77877"" lon=""17.66349"">
        <ele>45.3</ele>
      </trkpt>
      <trkpt lat=""59.77889"" lon=""17.6635199"">
        <ele>44.3</ele>
      </trkpt>
      <trkpt lat=""59.77959"" lon=""17.66366"">
        <ele>39.4</ele>
      </trkpt>
      <trkpt lat=""59.78002"" lon=""17.66374"">
        <ele>36.7</ele>
      </trkpt>
      <trkpt lat=""59.78097"" lon=""17.66392"">
        <ele>32.0</ele>
      </trkpt>
      <trkpt lat=""59.78149"" lon=""17.66401"">
        <ele>31.6</ele>
      </trkpt>
      <trkpt lat=""59.78177"" lon=""17.66407"">
        <ele>31.3</ele>
      </trkpt>
      <trkpt lat=""59.782"" lon=""17.66412"">
        <ele>30.8</ele>
      </trkpt>
      <trkpt lat=""59.78237"" lon=""17.6642"">
        <ele>30.0</ele>
      </trkpt>
      <trkpt lat=""59.78275"" lon=""17.66433"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.78308"" lon=""17.66448"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.78308"" lon=""17.66448"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.78328"" lon=""17.66458"">
        <ele>27.0</ele>
      </trkpt>
      <trkpt lat=""59.78334"" lon=""17.66461"">
        <ele>26.7</ele>
      </trkpt>
      <trkpt lat=""59.78337"" lon=""17.66467"">
        <ele>27.1</ele>
      </trkpt>
      <trkpt lat=""59.7836"" lon=""17.66481"">
        <ele>27.0</ele>
      </trkpt>
      <trkpt lat=""59.78399"" lon=""17.66509"">
        <ele>27.1</ele>
      </trkpt>
      <trkpt lat=""59.78447"" lon=""17.66545"">
        <ele>29.5</ele>
      </trkpt>
      <trkpt lat=""59.78475"" lon=""17.66571"">
        <ele>31.5</ele>
      </trkpt>
      <trkpt lat=""59.78483"" lon=""17.66579"">
        <ele>32.1</ele>
      </trkpt>
      <trkpt lat=""59.78483"" lon=""17.66579"">
        <ele>32.1</ele>
      </trkpt>
      <trkpt lat=""59.78487"" lon=""17.66563"">
        <ele>30.2</ele>
      </trkpt>
      <trkpt lat=""59.78492"" lon=""17.66539"">
        <ele>27.4</ele>
      </trkpt>
      <trkpt lat=""59.78493"" lon=""17.66537"">
        <ele>27.2</ele>
      </trkpt>
      <trkpt lat=""59.785"" lon=""17.66519"">
        <ele>25.1</ele>
      </trkpt>
      <trkpt lat=""59.78505"" lon=""17.66512"">
        <ele>24.2</ele>
      </trkpt>
      <trkpt lat=""59.7851"" lon=""17.66508"">
        <ele>23.7</ele>
      </trkpt>
      <trkpt lat=""59.78514"" lon=""17.66507"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.78518"" lon=""17.66506"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.78527"" lon=""17.66509"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.78537"" lon=""17.66514"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.78542"" lon=""17.6651"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.78572"" lon=""17.66519"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.78586"" lon=""17.66522"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.786"" lon=""17.66523"">
        <ele>22.9</ele>
      </trkpt>
      <trkpt lat=""59.78612"" lon=""17.66522"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.78628"" lon=""17.66517"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.78628"" lon=""17.66517"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.78645"" lon=""17.66525"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.78669"" lon=""17.66524"">
        <ele>17.6</ele>
      </trkpt>
      <trkpt lat=""59.78699"" lon=""17.6652099"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.78707"" lon=""17.6652"">
        <ele>16.7</ele>
      </trkpt>
      <trkpt lat=""59.78745"" lon=""17.66509"">
        <ele>15.6</ele>
      </trkpt>
      <trkpt lat=""59.78773"" lon=""17.66499"">
        <ele>14.4</ele>
      </trkpt>
      <trkpt lat=""59.78796"" lon=""17.66498"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.78827"" lon=""17.66499"">
        <ele>13.2</ele>
      </trkpt>
      <trkpt lat=""59.78862"" lon=""17.66499"">
        <ele>13.4</ele>
      </trkpt>
      <trkpt lat=""59.78877"" lon=""17.66504"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.78891"" lon=""17.66514"">
        <ele>15.1</ele>
      </trkpt>
      <trkpt lat=""59.78916"" lon=""17.6654"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.78929"" lon=""17.66552"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.7894"" lon=""17.66561"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.78941"" lon=""17.66562"">
        <ele>19.8</ele>
      </trkpt>
      <trkpt lat=""59.78978"" lon=""17.66586"">
        <ele>21.1</ele>
      </trkpt>
      <trkpt lat=""59.78991"" lon=""17.6659599"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.79004"" lon=""17.66608"">
        <ele>22.4</ele>
      </trkpt>
      <trkpt lat=""59.79014"" lon=""17.66619"">
        <ele>22.2</ele>
      </trkpt>
      <trkpt lat=""59.79026"" lon=""17.66634"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.79042"" lon=""17.6666"">
        <ele>21.0</ele>
      </trkpt>
      <trkpt lat=""59.79065"" lon=""17.66707"">
        <ele>21.5</ele>
      </trkpt>
      <trkpt lat=""59.79085"" lon=""17.66744"">
        <ele>22.1</ele>
      </trkpt>
      <trkpt lat=""59.79108"" lon=""17.6678"">
        <ele>23.8</ele>
      </trkpt>
      <trkpt lat=""59.79129"" lon=""17.66806"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.79153"" lon=""17.6683"">
        <ele>22.0</ele>
      </trkpt>
      <trkpt lat=""59.79168"" lon=""17.66843"">
        <ele>21.3</ele>
      </trkpt>
      <trkpt lat=""59.79204"" lon=""17.66866"">
        <ele>21.5</ele>
      </trkpt>
      <trkpt lat=""59.79227"" lon=""17.6688"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.79256"" lon=""17.66894"">
        <ele>21.9</ele>
      </trkpt>
      <trkpt lat=""59.79279"" lon=""17.66903"">
        <ele>22.4</ele>
      </trkpt>
      <trkpt lat=""59.79298"" lon=""17.66909"">
        <ele>22.5</ele>
      </trkpt>
      <trkpt lat=""59.79325"" lon=""17.66917"">
        <ele>22.5</ele>
      </trkpt>
      <trkpt lat=""59.79343"" lon=""17.66923"">
        <ele>22.0</ele>
      </trkpt>
      <trkpt lat=""59.7936"" lon=""17.6693399"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.79375"" lon=""17.66948"">
        <ele>21.8</ele>
      </trkpt>
      <trkpt lat=""59.79406"" lon=""17.66986"">
        <ele>21.5</ele>
      </trkpt>
      <trkpt lat=""59.79423"" lon=""17.67005"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.79441"" lon=""17.67022"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.79455"" lon=""17.67032"">
        <ele>19.5</ele>
      </trkpt>
      <trkpt lat=""59.79471"" lon=""17.67039"">
        <ele>18.1</ele>
      </trkpt>
      <trkpt lat=""59.79484"" lon=""17.6704"">
        <ele>16.7</ele>
      </trkpt>
      <trkpt lat=""59.79495"" lon=""17.67038"">
        <ele>15.4</ele>
      </trkpt>
      <trkpt lat=""59.79513"" lon=""17.6703699"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.79527"" lon=""17.67038"">
        <ele>15.4</ele>
      </trkpt>
      <trkpt lat=""59.79537"" lon=""17.67039"">
        <ele>15.6</ele>
      </trkpt>
      <trkpt lat=""59.79542"" lon=""17.67041"">
        <ele>15.7</ele>
      </trkpt>
      <trkpt lat=""59.79553"" lon=""17.67047"">
        <ele>16.1</ele>
      </trkpt>
      <trkpt lat=""59.79589"" lon=""17.67069"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.79606"" lon=""17.67083"">
        <ele>17.0</ele>
      </trkpt>
      <trkpt lat=""59.79646"" lon=""17.67115"">
        <ele>17.5</ele>
      </trkpt>
      <trkpt lat=""59.7966"" lon=""17.67126"">
        <ele>17.6</ele>
      </trkpt>
      <trkpt lat=""59.79683"" lon=""17.67141"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.79708"" lon=""17.67155"">
        <ele>15.7</ele>
      </trkpt>
      <trkpt lat=""59.7974"" lon=""17.6717"">
        <ele>14.8</ele>
      </trkpt>
      <trkpt lat=""59.79753"" lon=""17.67174"">
        <ele>14.7</ele>
      </trkpt>
      <trkpt lat=""59.79771"" lon=""17.67177"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.79789"" lon=""17.67179"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.79824"" lon=""17.67176"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.7986"" lon=""17.67174"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.79888"" lon=""17.67173"">
        <ele>12.9</ele>
      </trkpt>
      <trkpt lat=""59.79908"" lon=""17.67171"">
        <ele>13.2</ele>
      </trkpt>
      <trkpt lat=""59.79924"" lon=""17.6716799"">
        <ele>13.6</ele>
      </trkpt>
      <trkpt lat=""59.79958"" lon=""17.67155"">
        <ele>15.6</ele>
      </trkpt>
      <trkpt lat=""59.79966"" lon=""17.67153"">
        <ele>16.0</ele>
      </trkpt>
      <trkpt lat=""59.79968"" lon=""17.67152"">
        <ele>16.1</ele>
      </trkpt>
      <trkpt lat=""59.79997"" lon=""17.67153"">
        <ele>18.1</ele>
      </trkpt>
      <trkpt lat=""59.80026"" lon=""17.67156"">
        <ele>18.4</ele>
      </trkpt>
      <trkpt lat=""59.8007"" lon=""17.67161"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.80098"" lon=""17.67166"">
        <ele>19.0</ele>
      </trkpt>
      <trkpt lat=""59.80109"" lon=""17.6716799"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.80135"" lon=""17.67171"">
        <ele>19.6</ele>
      </trkpt>
      <trkpt lat=""59.80151"" lon=""17.67169"">
        <ele>19.3</ele>
      </trkpt>
      <trkpt lat=""59.80169"" lon=""17.67164"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.80187"" lon=""17.67155"">
        <ele>18.4</ele>
      </trkpt>
      <trkpt lat=""59.80204"" lon=""17.67149"">
        <ele>18.1</ele>
      </trkpt>
      <trkpt lat=""59.80222"" lon=""17.67147"">
        <ele>18.1</ele>
      </trkpt>
      <trkpt lat=""59.80253"" lon=""17.67148"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.80272"" lon=""17.67148"">
        <ele>17.2</ele>
      </trkpt>
      <trkpt lat=""59.80274"" lon=""17.67148"">
        <ele>17.1</ele>
      </trkpt>
      <trkpt lat=""59.80348"" lon=""17.67148"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.80391"" lon=""17.67148"">
        <ele>15.4</ele>
      </trkpt>
      <trkpt lat=""59.80418"" lon=""17.67148"">
        <ele>16.1</ele>
      </trkpt>
      <trkpt lat=""59.80441"" lon=""17.67148"">
        <ele>15.1</ele>
      </trkpt>
      <trkpt lat=""59.80448"" lon=""17.67148"">
        <ele>14.9</ele>
      </trkpt>
      <trkpt lat=""59.80467"" lon=""17.67151"">
        <ele>14.2</ele>
      </trkpt>
      <trkpt lat=""59.80486"" lon=""17.67157"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.80498"" lon=""17.67163"">
        <ele>13.0</ele>
      </trkpt>
      <trkpt lat=""59.80509"" lon=""17.67169"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.80536"" lon=""17.67192"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.8058"" lon=""17.6723"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.80606"" lon=""17.67254"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.80627"" lon=""17.67282"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.80643"" lon=""17.67301"">
        <ele>12.7</ele>
      </trkpt>
      <trkpt lat=""59.80661"" lon=""17.67318"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.80703"" lon=""17.67349"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.8073"" lon=""17.6737"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.80741"" lon=""17.67382"">
        <ele>12.1</ele>
      </trkpt>
      <trkpt lat=""59.80749"" lon=""17.67393"">
        <ele>12.0</ele>
      </trkpt>
      <trkpt lat=""59.80756"" lon=""17.67406"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.80765"" lon=""17.67426"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.80776"" lon=""17.6745899"">
        <ele>12.2</ele>
      </trkpt>
      <trkpt lat=""59.80778"" lon=""17.67466"">
        <ele>12.3</ele>
      </trkpt>
      <trkpt lat=""59.80795"" lon=""17.6752"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.80808"" lon=""17.6755299"">
        <ele>15.0</ele>
      </trkpt>
      <trkpt lat=""59.80824"" lon=""17.67585"">
        <ele>16.3</ele>
      </trkpt>
      <trkpt lat=""59.80836"" lon=""17.67607"">
        <ele>17.0</ele>
      </trkpt>
      <trkpt lat=""59.80866"" lon=""17.67652"">
        <ele>17.8</ele>
      </trkpt>
      <trkpt lat=""59.80883"" lon=""17.67679"">
        <ele>18.5</ele>
      </trkpt>
      <trkpt lat=""59.80885"" lon=""17.67683"">
        <ele>18.7</ele>
      </trkpt>
      <trkpt lat=""59.80901"" lon=""17.67707"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.80931"" lon=""17.67751"">
        <ele>21.2</ele>
      </trkpt>
      <trkpt lat=""59.80941"" lon=""17.67762"">
        <ele>21.3</ele>
      </trkpt>
      <trkpt lat=""59.80974"" lon=""17.67786"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.8098"" lon=""17.67792"">
        <ele>20.5</ele>
      </trkpt>
      <trkpt lat=""59.80985"" lon=""17.67796"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.80996"" lon=""17.67806"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.81003"" lon=""17.67818"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.81017"" lon=""17.67843"">
        <ele>20.0</ele>
      </trkpt>
      <trkpt lat=""59.81037"" lon=""17.6789999"">
        <ele>20.8</ele>
      </trkpt>
      <trkpt lat=""59.81051"" lon=""17.67942"">
        <ele>21.0</ele>
      </trkpt>
      <trkpt lat=""59.81056"" lon=""17.67954"">
        <ele>20.9</ele>
      </trkpt>
      <trkpt lat=""59.81064"" lon=""17.67971"">
        <ele>20.3</ele>
      </trkpt>
      <trkpt lat=""59.8107"" lon=""17.67982"">
        <ele>19.8</ele>
      </trkpt>
      <trkpt lat=""59.81073"" lon=""17.67986"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.81083"" lon=""17.67997"">
        <ele>18.0</ele>
      </trkpt>
      <trkpt lat=""59.81095"" lon=""17.68007"">
        <ele>17.2</ele>
      </trkpt>
      <trkpt lat=""59.81116"" lon=""17.68021"">
        <ele>15.9</ele>
      </trkpt>
      <trkpt lat=""59.81134"" lon=""17.68028"">
        <ele>14.7</ele>
      </trkpt>
      <trkpt lat=""59.8116"" lon=""17.68034"">
        <ele>12.9</ele>
      </trkpt>
      <trkpt lat=""59.81192"" lon=""17.68039"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.81205"" lon=""17.68038"">
        <ele>14.1</ele>
      </trkpt>
      <trkpt lat=""59.81246"" lon=""17.68035"">
        <ele>15.8</ele>
      </trkpt>
      <trkpt lat=""59.81272"" lon=""17.68034"">
        <ele>16.3</ele>
      </trkpt>
      <trkpt lat=""59.81288"" lon=""17.68035"">
        <ele>16.5</ele>
      </trkpt>
      <trkpt lat=""59.81292"" lon=""17.68036"">
        <ele>16.5</ele>
      </trkpt>
      <trkpt lat=""59.81293"" lon=""17.68036"">
        <ele>16.5</ele>
      </trkpt>
      <trkpt lat=""59.81304"" lon=""17.68043"">
        <ele>16.6</ele>
      </trkpt>
      <trkpt lat=""59.81319"" lon=""17.6805999"">
        <ele>16.8</ele>
      </trkpt>
      <trkpt lat=""59.81326"" lon=""17.68071"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.81326"" lon=""17.68072"">
        <ele>16.9</ele>
      </trkpt>
      <trkpt lat=""59.81344"" lon=""17.68099"">
        <ele>17.3</ele>
      </trkpt>
      <trkpt lat=""59.81347"" lon=""17.68103"">
        <ele>17.4</ele>
      </trkpt>
      <trkpt lat=""59.81351"" lon=""17.6811"">
        <ele>17.5</ele>
      </trkpt>
      <trkpt lat=""59.8138"" lon=""17.68166"">
        <ele>17.7</ele>
      </trkpt>
      <trkpt lat=""59.81396"" lon=""17.6820099"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.81415"" lon=""17.68245"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.81429"" lon=""17.6828"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.8143"" lon=""17.6828"">
        <ele>18.9</ele>
      </trkpt>
      <trkpt lat=""59.81446"" lon=""17.68324"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.81455"" lon=""17.68353"">
        <ele>19.7</ele>
      </trkpt>
      <trkpt lat=""59.81467"" lon=""17.68418"">
        <ele>21.2</ele>
      </trkpt>
      <trkpt lat=""59.81468"" lon=""17.68438"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.81467"" lon=""17.68458"">
        <ele>22.2</ele>
      </trkpt>
      <trkpt lat=""59.81451"" lon=""17.68558"">
        <ele>22.8</ele>
      </trkpt>
      <trkpt lat=""59.81419"" lon=""17.68743"">
        <ele>23.9</ele>
      </trkpt>
      <trkpt lat=""59.81411"" lon=""17.68795"">
        <ele>24.5</ele>
      </trkpt>
      <trkpt lat=""59.81411"" lon=""17.68797"">
        <ele>24.6</ele>
      </trkpt>
      <trkpt lat=""59.81399"" lon=""17.68859"">
        <ele>25.3</ele>
      </trkpt>
      <trkpt lat=""59.81394"" lon=""17.68929"">
        <ele>26.1</ele>
      </trkpt>
      <trkpt lat=""59.81393"" lon=""17.68939"">
        <ele>26.3</ele>
      </trkpt>
      <trkpt lat=""59.81393"" lon=""17.6898"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.81394"" lon=""17.69021"">
        <ele>27.3</ele>
      </trkpt>
      <trkpt lat=""59.814"" lon=""17.69069"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.81406"" lon=""17.69106"">
        <ele>28.3</ele>
      </trkpt>
      <trkpt lat=""59.81416"" lon=""17.6915"">
        <ele>28.8</ele>
      </trkpt>
      <trkpt lat=""59.81428"" lon=""17.69189"">
        <ele>28.6</ele>
      </trkpt>
      <trkpt lat=""59.81443"" lon=""17.69226"">
        <ele>28.2</ele>
      </trkpt>
      <trkpt lat=""59.81447"" lon=""17.69236"">
        <ele>28.1</ele>
      </trkpt>
      <trkpt lat=""59.8147"" lon=""17.69276"">
        <ele>27.6</ele>
      </trkpt>
      <trkpt lat=""59.81495"" lon=""17.6930799"">
        <ele>27.3</ele>
      </trkpt>
      <trkpt lat=""59.81508"" lon=""17.69321"">
        <ele>27.5</ele>
      </trkpt>
      <trkpt lat=""59.81519"" lon=""17.6933"">
        <ele>28.0</ele>
      </trkpt>
      <trkpt lat=""59.8155"" lon=""17.6935"">
        <ele>29.4</ele>
      </trkpt>
      <trkpt lat=""59.81564"" lon=""17.69358"">
        <ele>30.0</ele>
      </trkpt>
      <trkpt lat=""59.81572"" lon=""17.69362"">
        <ele>30.3</ele>
      </trkpt>
      <trkpt lat=""59.81604"" lon=""17.69384"">
        <ele>30.7</ele>
      </trkpt>
      <trkpt lat=""59.81606"" lon=""17.69385"">
        <ele>30.8</ele>
      </trkpt>
      <trkpt lat=""59.81659"" lon=""17.6942"">
        <ele>30.8</ele>
      </trkpt>
      <trkpt lat=""59.81709"" lon=""17.6945799"">
        <ele>28.5</ele>
      </trkpt>
      <trkpt lat=""59.81766"" lon=""17.69508"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.81766"" lon=""17.69508"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.81759"" lon=""17.6954"">
        <ele>27.4</ele>
      </trkpt>
      <trkpt lat=""59.81759"" lon=""17.6954"">
        <ele>27.4</ele>
      </trkpt>
      <trkpt lat=""59.81771"" lon=""17.6955"">
        <ele>27.9</ele>
      </trkpt>
      <trkpt lat=""59.81777"" lon=""17.69555"">
        <ele>28.1</ele>
      </trkpt>
      <trkpt lat=""59.81782"" lon=""17.69559"">
        <ele>28.3</ele>
      </trkpt>
      <trkpt lat=""59.81787"" lon=""17.69564"">
        <ele>28.4</ele>
      </trkpt>
      <trkpt lat=""59.81793"" lon=""17.69575"">
        <ele>28.6</ele>
      </trkpt>
      <trkpt lat=""59.81801"" lon=""17.69588"">
        <ele>28.8</ele>
      </trkpt>
      <trkpt lat=""59.81808"" lon=""17.69596"">
        <ele>29.0</ele>
      </trkpt>
      <trkpt lat=""59.81818"" lon=""17.69604"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.81826"" lon=""17.69611"">
        <ele>29.5</ele>
      </trkpt>
      <trkpt lat=""59.81841"" lon=""17.69615"">
        <ele>29.3</ele>
      </trkpt>
      <trkpt lat=""59.81853"" lon=""17.69615"">
        <ele>28.9</ele>
      </trkpt>
      <trkpt lat=""59.81864"" lon=""17.69616"">
        <ele>28.5</ele>
      </trkpt>
      <trkpt lat=""59.81874"" lon=""17.69619"">
        <ele>28.1</ele>
      </trkpt>
      <trkpt lat=""59.81881"" lon=""17.69625"">
        <ele>27.8</ele>
      </trkpt>
      <trkpt lat=""59.81889"" lon=""17.69635"">
        <ele>27.4</ele>
      </trkpt>
      <trkpt lat=""59.81897"" lon=""17.69648"">
        <ele>26.9</ele>
      </trkpt>
      <trkpt lat=""59.819"" lon=""17.69654"">
        <ele>26.8</ele>
      </trkpt>
      <trkpt lat=""59.81908"" lon=""17.69671"">
        <ele>26.3</ele>
      </trkpt>
      <trkpt lat=""59.81918"" lon=""17.69692"">
        <ele>26.0</ele>
      </trkpt>
      <trkpt lat=""59.81927"" lon=""17.69701"">
        <ele>25.9</ele>
      </trkpt>
      <trkpt lat=""59.81939"" lon=""17.69707"">
        <ele>25.7</ele>
      </trkpt>
      <trkpt lat=""59.8195"" lon=""17.69705"">
        <ele>25.6</ele>
      </trkpt>
      <trkpt lat=""59.81962"" lon=""17.6969"">
        <ele>25.5</ele>
      </trkpt>
      <trkpt lat=""59.81968"" lon=""17.69676"">
        <ele>25.4</ele>
      </trkpt>
      <trkpt lat=""59.81974"" lon=""17.69662"">
        <ele>25.4</ele>
      </trkpt>
      <trkpt lat=""59.8198"" lon=""17.6964599"">
        <ele>25.5</ele>
      </trkpt>
      <trkpt lat=""59.81988"" lon=""17.69643"">
        <ele>25.4</ele>
      </trkpt>
      <trkpt lat=""59.81998"" lon=""17.69638"">
        <ele>25.4</ele>
      </trkpt>
      <trkpt lat=""59.82011"" lon=""17.69633"">
        <ele>25.3</ele>
      </trkpt>
      <trkpt lat=""59.82022"" lon=""17.6962699"">
        <ele>25.2</ele>
      </trkpt>
      <trkpt lat=""59.82036"" lon=""17.69624"">
        <ele>25.1</ele>
      </trkpt>
      <trkpt lat=""59.82047"" lon=""17.69622"">
        <ele>25.0</ele>
      </trkpt>
      <trkpt lat=""59.82048"" lon=""17.69624"">
        <ele>24.9</ele>
      </trkpt>
      <trkpt lat=""59.82049"" lon=""17.69625"">
        <ele>24.9</ele>
      </trkpt>
      <trkpt lat=""59.82058"" lon=""17.6962699"">
        <ele>24.8</ele>
      </trkpt>
      <trkpt lat=""59.8207"" lon=""17.69628"">
        <ele>24.6</ele>
      </trkpt>
      <trkpt lat=""59.82078"" lon=""17.6963"">
        <ele>24.5</ele>
      </trkpt>
      <trkpt lat=""59.82081"" lon=""17.69632"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.82085"" lon=""17.69634"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.82091"" lon=""17.69638"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.82091"" lon=""17.69638"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.82091"" lon=""17.69631"">
        <ele>24.4</ele>
      </trkpt>
      <trkpt lat=""59.82091"" lon=""17.69638"">
        <ele>24.3</ele>
      </trkpt>
      <trkpt lat=""59.82092"" lon=""17.69789"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.82092"" lon=""17.69789"">
        <ele>24.0</ele>
      </trkpt>
      <trkpt lat=""59.82119"" lon=""17.69786"">
        <ele>23.8</ele>
      </trkpt>
      <trkpt lat=""59.82119"" lon=""17.69786"">
        <ele>23.8</ele>
      </trkpt>
      <trkpt lat=""59.82119"" lon=""17.6980499"">
        <ele>23.7</ele>
      </trkpt>
      <trkpt lat=""59.82119"" lon=""17.6980499"">
        <ele>23.7</ele>
      </trkpt>
      <trkpt lat=""59.82124"" lon=""17.6981499"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.82125"" lon=""17.6982399"">
        <ele>23.6</ele>
      </trkpt>
      <trkpt lat=""59.82127"" lon=""17.69834"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.82128"" lon=""17.69844"">
        <ele>23.5</ele>
      </trkpt>
      <trkpt lat=""59.82131"" lon=""17.69856"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.82134"" lon=""17.69867"">
        <ele>23.4</ele>
      </trkpt>
      <trkpt lat=""59.82138"" lon=""17.69873"">
        <ele>23.3</ele>
      </trkpt>
      <trkpt lat=""59.82143"" lon=""17.69877"">
        <ele>23.3</ele>
      </trkpt>
      <trkpt lat=""59.82148"" lon=""17.69879"">
        <ele>23.2</ele>
      </trkpt>
      <trkpt lat=""59.82154"" lon=""17.69879"">
        <ele>23.2</ele>
      </trkpt>
      <trkpt lat=""59.82159"" lon=""17.69881"">
        <ele>23.1</ele>
      </trkpt>
      <trkpt lat=""59.82171"" lon=""17.69879"">
        <ele>22.9</ele>
      </trkpt>
      <trkpt lat=""59.82192"" lon=""17.69875"">
        <ele>22.7</ele>
      </trkpt>
      <trkpt lat=""59.82223"" lon=""17.6987"">
        <ele>22.3</ele>
      </trkpt>
      <trkpt lat=""59.82239"" lon=""17.69868"">
        <ele>22.1</ele>
      </trkpt>
      <trkpt lat=""59.82257"" lon=""17.69864"">
        <ele>21.7</ele>
      </trkpt>
      <trkpt lat=""59.82277"" lon=""17.69857"">
        <ele>21.0</ele>
      </trkpt>
      <trkpt lat=""59.82288"" lon=""17.69854"">
        <ele>20.6</ele>
      </trkpt>
      <trkpt lat=""59.82347"" lon=""17.69825"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.82349"" lon=""17.6982399"">
        <ele>19.1</ele>
      </trkpt>
      <trkpt lat=""59.82357"" lon=""17.69819"">
        <ele>19.2</ele>
      </trkpt>
      <trkpt lat=""59.82393"" lon=""17.69799"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.82424"" lon=""17.69779"">
        <ele>19.4</ele>
      </trkpt>
      <trkpt lat=""59.82447"" lon=""17.69759"">
        <ele>18.8</ele>
      </trkpt>
      <trkpt lat=""59.82466"" lon=""17.69743"">
        <ele>18.3</ele>
      </trkpt>
      <trkpt lat=""59.82502"" lon=""17.6971"">
        <ele>17.4</ele>
      </trkpt>
      <trkpt lat=""59.8252"" lon=""17.69692"">
        <ele>17.0</ele>
      </trkpt>
      <trkpt lat=""59.82545"" lon=""17.69669"">
        <ele>16.4</ele>
      </trkpt>
      <trkpt lat=""59.82598"" lon=""17.69619"">
        <ele>15.6</ele>
      </trkpt>
      <trkpt lat=""59.82647"" lon=""17.69572"">
        <ele>14.9</ele>
      </trkpt>
      <trkpt lat=""59.82665"" lon=""17.69553"">
        <ele>14.4</ele>
      </trkpt>
      <trkpt lat=""59.82671"" lon=""17.69548"">
        <ele>14.3</ele>
      </trkpt>
      <trkpt lat=""59.82684"" lon=""17.69539"">
        <ele>14.1</ele>
      </trkpt>
      <trkpt lat=""59.82699"" lon=""17.69526"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.82734"" lon=""17.69493"">
        <ele>13.6</ele>
      </trkpt>
      <trkpt lat=""59.82761"" lon=""17.69467"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.82771"" lon=""17.69455"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.82775"" lon=""17.6945"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.8278"" lon=""17.69443"">
        <ele>13.7</ele>
      </trkpt>
      <trkpt lat=""59.82786"" lon=""17.69432"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.82792"" lon=""17.69424"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.82798"" lon=""17.69422"">
        <ele>13.5</ele>
      </trkpt>
      <trkpt lat=""59.82803"" lon=""17.69419"">
        <ele>13.4</ele>
      </trkpt>
      <trkpt lat=""59.82809"" lon=""17.69415"">
        <ele>13.2</ele>
      </trkpt>
      <trkpt lat=""59.82814"" lon=""17.6941"">
        <ele>13.1</ele>
      </trkpt>
      <trkpt lat=""59.82819"" lon=""17.69404"">
        <ele>13.0</ele>
      </trkpt>
      <trkpt lat=""59.82827"" lon=""17.69394"">
        <ele>12.8</ele>
      </trkpt>
      <trkpt lat=""59.82831"" lon=""17.6939"">
        <ele>12.8</ele>
      </trkpt>
      <trkpt lat=""59.82841"" lon=""17.69382"">
        <ele>12.7</ele>
      </trkpt>
      <trkpt lat=""59.82847"" lon=""17.69379"">
        <ele>12.7</ele>
      </trkpt>
      <trkpt lat=""59.82852"" lon=""17.69375"">
        <ele>12.7</ele>
      </trkpt>
      <trkpt lat=""59.82873"" lon=""17.69358"">
        <ele>12.6</ele>
      </trkpt>
      <trkpt lat=""59.82875"" lon=""17.69356"">
        <ele>12.6</ele>
      </trkpt>
      <trkpt lat=""59.82947"" lon=""17.69287"">
        <ele>13.8</ele>
      </trkpt>
      <trkpt lat=""59.83035"" lon=""17.69204"">
        <ele>13.9</ele>
      </trkpt>
      <trkpt lat=""59.83068"" lon=""17.69172"">
        <ele>13.4</ele>
      </trkpt>
      <trkpt lat=""59.83074"" lon=""17.69162"">
        <ele>13.2</ele>
      </trkpt>
      <trkpt lat=""59.83088"" lon=""17.69148"">
        <ele>12.9</ele>
      </trkpt>
      <trkpt lat=""59.83097"" lon=""17.6914"">
        <ele>12.6</ele>
      </trkpt>
      <trkpt lat=""59.83105"" lon=""17.69133"">
        <ele>12.4</ele>
      </trkpt>
      <trkpt lat=""59.83112"" lon=""17.69127"">
        <ele>12.1</ele>
      </trkpt>
      <trkpt lat=""59.83115"" lon=""17.69121"">
        <ele>12.0</ele>
      </trkpt>
      <trkpt lat=""59.83119"" lon=""17.6911099"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.83124"" lon=""17.69095"">
        <ele>11.6</ele>
      </trkpt>
      <trkpt lat=""59.83134"" lon=""17.69068"">
        <ele>11.1</ele>
      </trkpt>
      <trkpt lat=""59.83137"" lon=""17.6906"">
        <ele>10.9</ele>
      </trkpt>
      <trkpt lat=""59.83142"" lon=""17.69056"">
        <ele>10.7</ele>
      </trkpt>
      <trkpt lat=""59.8316"" lon=""17.69044"">
        <ele>9.8</ele>
      </trkpt>
      <trkpt lat=""59.83187"" lon=""17.69029"">
        <ele>9.3</ele>
      </trkpt>
      <trkpt lat=""59.83203"" lon=""17.69019"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.83209"" lon=""17.69016"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.83214"" lon=""17.69015"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.8322"" lon=""17.6901699"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.83225"" lon=""17.6901699"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.83229"" lon=""17.6901699"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.83234"" lon=""17.69015"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.8324"" lon=""17.6901"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.8324"" lon=""17.6901"">
        <ele>9.0</ele>
      </trkpt>
      <trkpt lat=""59.83314"" lon=""17.68941"">
        <ele>7.7</ele>
      </trkpt>
      <trkpt lat=""59.83366"" lon=""17.68891"">
        <ele>7.0</ele>
      </trkpt>
      <trkpt lat=""59.83407"" lon=""17.6885"">
        <ele>7.0</ele>
      </trkpt>
      <trkpt lat=""59.83452"" lon=""17.68803"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83453"" lon=""17.68802"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83454"" lon=""17.68802"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83454"" lon=""17.68803"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83455"" lon=""17.68804"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83455"" lon=""17.68804"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.83557"" lon=""17.68702"">
        <ele>7.7</ele>
      </trkpt>
      <trkpt lat=""59.8363"" lon=""17.68629"">
        <ele>8.2</ele>
      </trkpt>
      <trkpt lat=""59.83647"" lon=""17.68611"">
        <ele>8.2</ele>
      </trkpt>
      <trkpt lat=""59.83658"" lon=""17.68597"">
        <ele>8.1</ele>
      </trkpt>
      <trkpt lat=""59.8367"" lon=""17.68578"">
        <ele>8.1</ele>
      </trkpt>
      <trkpt lat=""59.83677"" lon=""17.68568"">
        <ele>8.2</ele>
      </trkpt>
      <trkpt lat=""59.83683"" lon=""17.68563"">
        <ele>8.4</ele>
      </trkpt>
      <trkpt lat=""59.83702"" lon=""17.68549"">
        <ele>8.8</ele>
      </trkpt>
      <trkpt lat=""59.83712"" lon=""17.68538"">
        <ele>9.1</ele>
      </trkpt>
      <trkpt lat=""59.83736"" lon=""17.68505"">
        <ele>9.7</ele>
      </trkpt>
      <trkpt lat=""59.83795"" lon=""17.68424"">
        <ele>9.5</ele>
      </trkpt>
      <trkpt lat=""59.83871"" lon=""17.68308"">
        <ele>9.5</ele>
      </trkpt>
      <trkpt lat=""59.8396"" lon=""17.68158"">
        <ele>10.5</ele>
      </trkpt>
      <trkpt lat=""59.84131"" lon=""17.67829"">
        <ele>11.2</ele>
      </trkpt>
      <trkpt lat=""59.84276"" lon=""17.6755"">
        <ele>7.1</ele>
      </trkpt>
      <trkpt lat=""59.84352"" lon=""17.67398"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.84352"" lon=""17.67398"">
        <ele>11.9</ele>
      </trkpt>
      <trkpt lat=""59.84363"" lon=""17.67416"">
        <ele>11.3</ele>
      </trkpt>
      <trkpt lat=""59.84363"" lon=""17.67416"">
        <ele>11.3</ele>
      </trkpt>
      <trkpt lat=""59.84402"" lon=""17.6734"">
        <ele>11.4</ele>
      </trkpt>
      <trkpt lat=""59.84444"" lon=""17.67259"">
        <ele>10.1</ele>
      </trkpt>
      <trkpt lat=""59.84446"" lon=""17.67255"">
        <ele>10.1</ele>
      </trkpt>
      <trkpt lat=""59.84497"" lon=""17.67157"">
        <ele>8.0</ele>
      </trkpt>
      <trkpt lat=""59.84518"" lon=""17.67117"">
        <ele>8.4</ele>
      </trkpt>
    </trkseg>
  </trk>
</gpx>
";
        return gxp;
    }
}