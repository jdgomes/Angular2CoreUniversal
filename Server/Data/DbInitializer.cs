using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspCoreServer.Models;
using AspCoreServer;

namespace AspCoreServer.Data
{
  public static class DbInitializer
  {
    public static void Initialize(AwsContext context)
    {
      context.Database.EnsureCreated();

      if (context.User.Any())
      {
        return;   // DB has been seeded
      }
      CreateUsers(context);
      CreateSearchResults(context);
      context.SaveChanges();
    }

    private static void CreateUsers(AwsContext context)
    {
      var users = new User[]
                  {
               new User(){Name = "Mark Pieszak"},
               new User(){Name = "Abrar Jahin"},
               new User(){Name = "hakonamatata"},
               new User(){Name = "LiverpoolOwen"},
               new User(){Name = "Ketrex"},
               new User(){Name = "markwhitfeld"},
               new User(){Name = "daveo1001"},
               new User(){Name = "paonath"},
               new User(){Name = "nalex095"},
               new User(){Name = "ORuban"},
               new User(){Name = "Gaulomatic"}
                  };

      foreach (User s in users)
      {
        context.User.Add(s);
      }
    }
    private static void CreateSearchResults(AwsContext context)
    {

      context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Bryant Ranch Prepack",
        Hours = "M-F: 0AM - 3PM",
        Services = "outpatient procedures, operation, Support",
        EligibilityRequirements = "Age, Location",
        Website = "http://hubpages.com/eleifend/luctus/ultricies/eu/nibh/quisque.jpg?condimentum=consequat&neque=nulla&sapien=nisl&placerat=nunc&ante=nisl&nulla=duis&justo=bibendum&aliquam=felis&quis=sed&turpis=interdum&eget=venenatis&elit=turpis&sodales=enim&scelerisque=blandit&mauris=mi&sit=in&amet=porttitor&eros=pede&suspendisse=justo&accumsan=eu&tortor=massa&quis=donec&turpis=dapibus&sed=duis&ante=at&vivamus=velit",
        Phone = "611-928-6364",
        Email = "sdart0@about.com",
        Description = "faucibus orci luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed"
     ,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Liddell Laboratories, Inc.",
        Hours = "M-F: 2AM - 1PM",
        Services = "exams, outpatient procedures, scans",
        EligibilityRequirements = "Age, Insurance",
        Website = "http://comcast.net/fermentum.js?in=erat&faucibus=curabitur&orci=gravida&luctus=nisi&et=at&ultrices=nibh&posuere=in&cubilia=hac&curae=habitasse&nulla=platea&dapibus=dictumst&dolor=aliquam&vel=augue&est=quam&donec=sollicitudin&odio=vitae&justo=consectetuer&sollicitudin=eget&ut=rutrum&suscipit=at&a=lorem&feugiat=integer&et=tincidunt&eros=ante&vestibulum=vel&ac=ipsum&est=praesent&lacinia=blandit&nisi=lacinia&venenatis=erat&tristique=vestibulum&fusce=sed&congue=magna&diam=at&id=nunc&ornare=commodo&imperdiet=placerat&sapien=praesent&urna=blandit&pretium=nam&nisl=nulla&ut=integer&volutpat=pede&sapien=justo&arcu=lacinia&sed=eget&augue=tincidunt&aliquam=eget&erat=tempus&volutpat=vel&in=pede",
        Phone = "500-815-9375",
        Email = "efuster1@google.ru",
        Description = "at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at nunc commodo placerat praesent blandit nam nulla integer pede justo"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Care One (American Sales Company)",
        Hours = "M-F: 1AM - 8PM",
        Services = "checkups, operation, exams",
        EligibilityRequirements = "Location, Age",
        Website = "http://woothemes.com/sed/tristique/in/tempus.json?vulputate=suspendisse&ut=ornare&ultrices=consequat&vel=lectus&augue=in&vestibulum=est&ante=risus&ipsum=auctor&primis=sed&in=tristique&faucibus=in&orci=tempus&luctus=sit&et=amet&ultrices=sem&posuere=fusce&cubilia=consequat&curae=nulla&donec=nisl&pharetra=nunc&magna=nisl&vestibulum=duis&aliquet=bibendum&ultrices=felis&erat=sed&tortor=interdum&sollicitudin=venenatis&mi=turpis&sit=enim&amet=blandit&lobortis=mi&sapien=in&sapien=porttitor&non=pede&mi=justo&integer=eu&ac=massa&neque=donec&duis=dapibus&bibendum=duis&morbi=at&non=velit&quam=eu&nec=est&dui=congue&luctus=elementum&rutrum=in&nulla=hac&tellus=habitasse&in=platea&sagittis=dictumst&dui=morbi&vel=vestibulum&nisl=velit&duis=id&ac=pretium&nibh=iaculis&fusce=diam&lacus=erat&purus=fermentum&aliquet=justo&at=nec&feugiat=condimentum&non=neque&pretium=sapien&quis=placerat&lectus=ante&suspendisse=nulla&potenti=justo&in=aliquam&eleifend=quis&quam=turpis&a=eget&odio=elit&in=sodales&hac=scelerisque&habitasse=mauris&platea=sit&dictumst=amet&maecenas=eros&ut=suspendisse&massa=accumsan&quis=tortor",
        Phone = "609-201-4006",
        Email = "higoe2@state.tx.us",
        Description = "vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit amet sem fusce consequat nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Amerisource Bergen",
        Hours = "M-F: 1AM - 5PM",
        Services = "general medicine, checkups, scans",
        EligibilityRequirements = "Insurance, Location",
        Website = "http://myspace.com/sed/tristique/in/tempus/sit/amet.png?enim=curabitur&sit=gravida&amet=nisi&nunc=at&viverra=nibh&dapibus=in&nulla=hac&suscipit=habitasse&ligula=platea&in=dictumst&lacus=aliquam&curabitur=augue&at=quam&ipsum=sollicitudin&ac=vitae&tellus=consectetuer&semper=eget&interdum=rutrum&mauris=at&ullamcorper=lorem&purus=integer&sit=tincidunt&amet=ante&nulla=vel&quisque=ipsum&arcu=praesent&libero=blandit&rutrum=lacinia&ac=erat&lobortis=vestibulum&vel=sed&dapibus=magna&at=at",
        Phone = "560-288-7776",
        Email = "rgillbe3@indiegogo.com",
        Description = "turpis nec euismod scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula nec sem duis aliquam convallis nunc proin at turpis"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "WALGREEN CO.",
        Hours = "M-F: 3AM - 5PM",
        Services = "operation, checkups, exams",
        EligibilityRequirements = "Income, Location",
        Website = "https://shinystat.com/placerat/ante.xml?nunc=luctus&nisl=et&duis=ultrices&bibendum=posuere&felis=cubilia&sed=curae&interdum=nulla&venenatis=dapibus&turpis=dolor&enim=vel&blandit=est",
        Phone = "312-697-8749",
        Email = "kcassy4@surveymonkey.com",
        Description = "sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper porta volutpat quam pede lobortis"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Boots Retail USA Inc",
        Hours = "M-F: 2AM - 8PM",
        Services = "scans, Support, exams",
        EligibilityRequirements = "Income, Age",
        Website = "https://cnet.com/tempus.jsp?primis=proin&in=risus&faucibus=praesent&orci=lectus&luctus=vestibulum&et=quam&ultrices=sapien&posuere=varius&cubilia=ut&curae=blandit&donec=non&pharetra=interdum&magna=in&vestibulum=ante&aliquet=vestibulum&ultrices=ante&erat=ipsum&tortor=primis&sollicitudin=in&mi=faucibus&sit=orci&amet=luctus&lobortis=et&sapien=ultrices&sapien=posuere&non=cubilia&mi=curae&integer=duis&ac=faucibus&neque=accumsan&duis=odio&bibendum=curabitur&morbi=convallis&non=duis&quam=consequat&nec=dui&dui=nec&luctus=nisi&rutrum=volutpat&nulla=eleifend&tellus=donec&in=ut&sagittis=dolor&dui=morbi&vel=vel&nisl=lectus&duis=in&ac=quam&nibh=fringilla&fusce=rhoncus&lacus=mauris&purus=enim&aliquet=leo&at=rhoncus&feugiat=sed&non=vestibulum&pretium=sit&quis=amet&lectus=cursus&suspendisse=id&potenti=turpis&in=integer&eleifend=aliquet&quam=massa&a=id&odio=lobortis&in=convallis&hac=tortor&habitasse=risus&platea=dapibus&dictumst=augue&maecenas=vel&ut=accumsan&massa=tellus&quis=nisi",
        Phone = "373-783-0657",
        Email = "gmcmeekan5@clickbank.net",
        Description = "metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget orci vehicula condimentum curabitur in libero ut massa volutpat convallis morbi odio odio elementum eu interdum eu tincidunt in"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Aurobindo Pharma Limited",
        Hours = "M-F: 3AM - 2PM",
        Services = "Support, scans, operation",
        EligibilityRequirements = "Insurance, Age",
        Website = "http://fastcompany.com/accumsan.html?lorem=vel&vitae=est&mattis=donec&nibh=odio&ligula=justo&nec=sollicitudin&sem=ut&duis=suscipit&aliquam=a&convallis=feugiat&nunc=et&proin=eros",
        Phone = "332-378-0775",
        Email = "fmeddick6@sogou.com",
        Description = "congue eget semper rutrum nulla nunc purus phasellus in felis donec semper sapien a libero nam dui proin leo odio porttitor id consequat in consequat ut nulla"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "REMEDYREPACK INC.",
        Hours = "M-F: 1AM - 5PM",
        Services = "checkups, general medicine, scans",
        EligibilityRequirements = "Income, Age",
        Website = "https://google.cn/morbi/non/lectus.jpg?dignissim=mauris&vestibulum=enim&vestibulum=leo&ante=rhoncus&ipsum=sed&primis=vestibulum&in=sit&faucibus=amet&orci=cursus&luctus=id&et=turpis&ultrices=integer&posuere=aliquet&cubilia=massa&curae=id&nulla=lobortis&dapibus=convallis&dolor=tortor&vel=risus&est=dapibus&donec=augue&odio=vel&justo=accumsan&sollicitudin=tellus&ut=nisi&suscipit=eu&a=orci&feugiat=mauris",
        Phone = "837-611-8574",
        Email = "pbrookson7@census.gov",
        Description = "sed augue aliquam erat volutpat in congue etiam justo etiam pretium iaculis justo in hac habitasse platea dictumst etiam faucibus cursus urna ut"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "AnazaoHealth Corporation",
        Hours = "M-F: 6AM - 7PM",
        Services = "Support, operation, general medicine",
        EligibilityRequirements = "Age, Insurance",
        Website = "https://fc2.com/aliquam/erat/volutpat/in/congue/etiam/justo.html?aliquam=volutpat&convallis=in&nunc=congue&proin=etiam&at=justo&turpis=etiam&a=pretium&pede=iaculis&posuere=justo&nonummy=in&integer=hac&non=habitasse&velit=platea&donec=dictumst&diam=etiam&neque=faucibus&vestibulum=cursus&eget=urna&vulputate=ut&ut=tellus&ultrices=nulla&vel=ut&augue=erat&vestibulum=id&ante=mauris&ipsum=vulputate&primis=elementum&in=nullam&faucibus=varius&orci=nulla&luctus=facilisi&et=cras&ultrices=non&posuere=velit&cubilia=nec&curae=nisi&donec=vulputate&pharetra=nonummy&magna=maecenas&vestibulum=tincidunt&aliquet=lacus&ultrices=at&erat=velit&tortor=vivamus&sollicitudin=vel&mi=nulla&sit=eget&amet=eros&lobortis=elementum&sapien=pellentesque&sapien=quisque&non=porta&mi=volutpat&integer=erat&ac=quisque&neque=erat&duis=eros&bibendum=viverra&morbi=eget&non=congue&quam=eget&nec=semper&dui=rutrum&luctus=nulla&rutrum=nunc&nulla=purus&tellus=phasellus&in=in&sagittis=felis&dui=donec&vel=semper&nisl=sapien&duis=a&ac=libero&nibh=nam&fusce=dui&lacus=proin&purus=leo&aliquet=odio&at=porttitor&feugiat=id&non=consequat&pretium=in&quis=consequat&lectus=ut&suspendisse=nulla&potenti=sed&in=accumsan&eleifend=felis&quam=ut&a=at&odio=dolor&in=quis&hac=odio&habitasse=consequat&platea=varius",
        Phone = "486-249-5468",
        Email = "tescritt8@indiegogo.com",
        Description = "vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Ningbo Pulisi Daily Chemical Products Co., Ltd.",
        Hours = "M-F: 9AM - 8PM",
        Services = "exams, checkups, outpatient procedures",
        EligibilityRequirements = "Age, Income",
        Website = "http://sfgate.com/felis/donec/semper/sapien/a/libero/nam.png?quis=nulla&justo=tellus&maecenas=in&rhoncus=sagittis&aliquam=dui&lacus=vel&morbi=nisl&quis=duis&tortor=ac&id=nibh&nulla=fusce&ultrices=lacus&aliquet=purus&maecenas=aliquet&leo=at&odio=feugiat&condimentum=non&id=pretium&luctus=quis&nec=lectus&molestie=suspendisse&sed=potenti&justo=in&pellentesque=eleifend&viverra=quam&pede=a&ac=odio&diam=in&cras=hac&pellentesque=habitasse&volutpat=platea&dui=dictumst&maecenas=maecenas&tristique=ut&est=massa&et=quis&tempus=augue&semper=luctus&est=tincidunt&quam=nulla&pharetra=mollis&magna=molestie&ac=lorem&consequat=quisque&metus=ut&sapien=erat&ut=curabitur&nunc=gravida&vestibulum=nisi&ante=at&ipsum=nibh&primis=in&in=hac&faucibus=habitasse&orci=platea&luctus=dictumst&et=aliquam&ultrices=augue&posuere=quam&cubilia=sollicitudin",
        Phone = "129-627-0383",
        Email = "hmaggiore9@businesswire.com",
        Description = "maecenas tristique est et tempus semper est quam pharetra magna ac consequat metus sapien ut nunc vestibulum ante ipsum primis in faucibus orci luctus et ultrices"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Major Pharmaceuticals",
        Hours = "M-F: 5AM - 3PM",
        Services = "outpatient procedures, Support, general medicine",
        EligibilityRequirements = "Location, Age",
        Website = "https://pinterest.com/primis/in/faucibus/orci/luctus/et/ultrices.js?in=dictumst&felis=etiam&donec=faucibus&semper=cursus&sapien=urna&a=ut&libero=tellus&nam=nulla&dui=ut&proin=erat&leo=id&odio=mauris&porttitor=vulputate&id=elementum&consequat=nullam&in=varius&consequat=nulla&ut=facilisi&nulla=cras&sed=non&accumsan=velit&felis=nec&ut=nisi&at=vulputate&dolor=nonummy&quis=maecenas&odio=tincidunt&consequat=lacus&varius=at&integer=velit&ac=vivamus&leo=vel&pellentesque=nulla&ultrices=eget&mattis=eros&odio=elementum&donec=pellentesque&vitae=quisque&nisi=porta&nam=volutpat&ultrices=erat&libero=quisque&non=erat&mattis=eros&pulvinar=viverra&nulla=eget&pede=congue&ullamcorper=eget&augue=semper&a=rutrum&suscipit=nulla&nulla=nunc&elit=purus&ac=phasellus&nulla=in&sed=felis&vel=donec&enim=semper&sit=sapien&amet=a&nunc=libero&viverra=nam&dapibus=dui&nulla=proin&suscipit=leo&ligula=odio&in=porttitor&lacus=id",
        Phone = "712-921-3293",
        Email = "csamartha@free.fr",
        Description = "cursus id turpis integer aliquet massa id lobortis convallis tortor risus dapibus augue vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "White Manufacturing Incorporated DBA Micro-West",
        Hours = "M-F: 1AM - 7PM",
        Services = "scans, operation, general medicine",
        EligibilityRequirements = "Insurance, Age",
        Website = "https://netvibes.com/phasellus/sit/amet/erat/nulla/tempus/vivamus.jsp?amet=nascetur&nulla=ridiculus&quisque=mus&arcu=vivamus&libero=vestibulum&rutrum=sagittis&ac=sapien&lobortis=cum&vel=sociis&dapibus=natoque&at=penatibus&diam=et",
        Phone = "749-837-1016",
        Email = "fgohnb@bravesites.com",
        Description = "neque duis bibendum morbi non quam nec dui luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti in eleifend quam a odio in hac"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "AvKARE, Inc.",
        Hours = "M-F: 5AM - 3PM",
        Services = "outpatient procedures, exams, general medicine",
        EligibilityRequirements = "Age, Location",
        Website = "http://i2i.jp/fringilla/rhoncus/mauris/enim/leo/rhoncus.js?mauris=nec&morbi=condimentum&non=neque&lectus=sapien&aliquam=placerat&sit=ante&amet=nulla&diam=justo",
        Phone = "329-523-6877",
        Email = "gchambersc@disqus.com",
        Description = "integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "AvKARE, Inc.",
        Hours = "M-F: 7AM - 7PM",
        Services = "outpatient procedures, checkups, exams",
        EligibilityRequirements = "Insurance, Age",
        Website = "http://cam.ac.uk/integer.html?elit=lacinia&proin=erat&risus=vestibulum&praesent=sed&lectus=magna&vestibulum=at&quam=nunc&sapien=commodo&varius=placerat&ut=praesent&blandit=blandit&non=nam&interdum=nulla&in=integer&ante=pede&vestibulum=justo&ante=lacinia&ipsum=eget&primis=tincidunt&in=eget&faucibus=tempus&orci=vel&luctus=pede&et=morbi&ultrices=porttitor&posuere=lorem&cubilia=id&curae=ligula&duis=suspendisse&faucibus=ornare&accumsan=consequat&odio=lectus&curabitur=in&convallis=est&duis=risus&consequat=auctor&dui=sed&nec=tristique&nisi=in&volutpat=tempus&eleifend=sit&donec=amet&ut=sem&dolor=fusce&morbi=consequat&vel=nulla&lectus=nisl&in=nunc&quam=nisl&fringilla=duis&rhoncus=bibendum",
        Phone = "372-275-2890",
        Email = "ecampeyd@topsy.com",
        Description = "duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel lectus in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum sit amet cursus"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Golden State Medical Supply, Inc.",
        Hours = "M-F: 3AM - 0PM",
        Services = "outpatient procedures, general medicine, scans",
        EligibilityRequirements = "Income, Location",
        Website = "http://4shared.com/suspendisse/potenti/cras/in/purus/eu/magna.html?nec=rhoncus&nisi=mauris&volutpat=enim&eleifend=leo&donec=rhoncus&ut=sed&dolor=vestibulum&morbi=sit&vel=amet&lectus=cursus&in=id&quam=turpis&fringilla=integer&rhoncus=aliquet&mauris=massa&enim=id&leo=lobortis&rhoncus=convallis&sed=tortor&vestibulum=risus&sit=dapibus&amet=augue&cursus=vel&id=accumsan&turpis=tellus&integer=nisi&aliquet=eu&massa=orci&id=mauris&lobortis=lacinia&convallis=sapien&tortor=quis&risus=libero&dapibus=nullam&augue=sit&vel=amet&accumsan=turpis&tellus=elementum&nisi=ligula&eu=vehicula&orci=consequat&mauris=morbi&lacinia=a&sapien=ipsum&quis=integer&libero=a&nullam=nibh",
        Phone = "891-333-5568",
        Email = "cduddelle@marketwatch.com",
        Description = "diam in magna bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "CVS Pharmacy",
        Hours = "M-F: 3AM - 1PM",
        Services = "general medicine, Support, checkups",
        EligibilityRequirements = "Location, Income",
        Website = "https://reddit.com/lobortis/vel/dapibus/at/diam/nam/tristique.json?donec=platea&dapibus=dictumst&duis=etiam&at=faucibus&velit=cursus&eu=urna&est=ut&congue=tellus&elementum=nulla&in=ut&hac=erat&habitasse=id&platea=mauris&dictumst=vulputate&morbi=elementum&vestibulum=nullam&velit=varius&id=nulla&pretium=facilisi&iaculis=cras&diam=non&erat=velit&fermentum=nec&justo=nisi&nec=vulputate&condimentum=nonummy&neque=maecenas&sapien=tincidunt&placerat=lacus&ante=at&nulla=velit&justo=vivamus&aliquam=vel&quis=nulla&turpis=eget&eget=eros&elit=elementum&sodales=pellentesque&scelerisque=quisque&mauris=porta&sit=volutpat&amet=erat&eros=quisque&suspendisse=erat&accumsan=eros",
        Phone = "401-771-3588",
        Email = "rmarquotf@illinois.edu",
        Description = "pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac neque duis bibendum"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "NARS COSMETICS",
        Hours = "M-F: 4AM - 9PM",
        Services = "checkups, exams, outpatient procedures",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://accuweather.com/dictumst/aliquam/augue/quam/sollicitudin.jpg?tortor=pellentesque&risus=eget&dapibus=nunc&augue=donec&vel=quis&accumsan=orci&tellus=eget&nisi=orci&eu=vehicula&orci=condimentum&mauris=curabitur&lacinia=in&sapien=libero&quis=ut&libero=massa&nullam=volutpat&sit=convallis&amet=morbi&turpis=odio&elementum=odio&ligula=elementum&vehicula=eu&consequat=interdum&morbi=eu&a=tincidunt&ipsum=in&integer=leo&a=maecenas&nibh=pulvinar&in=lobortis&quis=est&justo=phasellus&maecenas=sit&rhoncus=amet&aliquam=erat&lacus=nulla&morbi=tempus&quis=vivamus&tortor=in&id=felis&nulla=eu&ultrices=sapien&aliquet=cursus&maecenas=vestibulum&leo=proin&odio=eu&condimentum=mi&id=nulla&luctus=ac&nec=enim&molestie=in&sed=tempor&justo=turpis&pellentesque=nec&viverra=euismod&pede=scelerisque&ac=quam&diam=turpis&cras=adipiscing",
        Phone = "105-415-0366",
        Email = "tstoiteg@phoca.cz",
        Description = "venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Two Hip Consulting, LLC",
        Hours = "M-F: 9AM - 7PM",
        Services = "checkups, general medicine, operation",
        EligibilityRequirements = "Insurance, Location",
        Website = "http://linkedin.com/in/quam/fringilla/rhoncus/mauris/enim.xml?sapien=nibh&cum=ligula&sociis=nec&natoque=sem&penatibus=duis&et=aliquam&magnis=convallis&dis=nunc&parturient=proin&montes=at&nascetur=turpis&ridiculus=a&mus=pede&etiam=posuere&vel=nonummy&augue=integer&vestibulum=non&rutrum=velit&rutrum=donec&neque=diam&aenean=neque&auctor=vestibulum&gravida=eget&sem=vulputate&praesent=ut&id=ultrices&massa=vel&id=augue&nisl=vestibulum&venenatis=ante&lacinia=ipsum&aenean=primis&sit=in&amet=faucibus&justo=orci&morbi=luctus&ut=et&odio=ultrices&cras=posuere&mi=cubilia&pede=curae&malesuada=donec&in=pharetra&imperdiet=magna&et=vestibulum&commodo=aliquet&vulputate=ultrices&justo=erat&in=tortor&blandit=sollicitudin&ultrices=mi&enim=sit&lorem=amet&ipsum=lobortis&dolor=sapien&sit=sapien&amet=non&consectetuer=mi&adipiscing=integer&elit=ac&proin=neque&interdum=duis&mauris=bibendum&non=morbi&ligula=non&pellentesque=quam&ultrices=nec&phasellus=dui&id=luctus&sapien=rutrum&in=nulla&sapien=tellus&iaculis=in",
        Phone = "804-819-2380",
        Email = "ugillbeeh@myspace.com",
        Description = "fusce consequat nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede justo eu massa donec dapibus"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Mary Kay Inc.",
        Hours = "M-F: 5AM - 5PM",
        Services = "checkups, operation, general medicine",
        EligibilityRequirements = "Income, Location",
        Website = "http://goo.ne.jp/penatibus/et/magnis/dis/parturient/montes.xml?nulla=ultricies&ut=eu&erat=nibh&id=quisque&mauris=id&vulputate=justo&elementum=sit&nullam=amet&varius=sapien&nulla=dignissim&facilisi=vestibulum&cras=vestibulum&non=ante&velit=ipsum&nec=primis&nisi=in&vulputate=faucibus&nonummy=orci&maecenas=luctus&tincidunt=et&lacus=ultrices&at=posuere&velit=cubilia&vivamus=curae&vel=nulla&nulla=dapibus&eget=dolor&eros=vel&elementum=est&pellentesque=donec&quisque=odio&porta=justo&volutpat=sollicitudin&erat=ut&quisque=suscipit&erat=a&eros=feugiat&viverra=et&eget=eros",
        Phone = "637-491-6936",
        Email = "azanottii@statcounter.com",
        Description = "congue vivamus metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget orci vehicula condimentum curabitur in libero ut"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Allermed Laboratories, Inc.",
        Hours = "M-F: 6AM - 9PM",
        Services = "outpatient procedures, general medicine, checkups",
        EligibilityRequirements = "Age, Insurance",
        Website = "http://wordpress.org/ultrices/posuere/cubilia/curae.json?porttitor=mi&lacus=sit&at=amet&turpis=lobortis&donec=sapien&posuere=sapien&metus=non&vitae=mi&ipsum=integer&aliquam=ac&non=neque&mauris=duis&morbi=bibendum&non=morbi&lectus=non&aliquam=quam&sit=nec&amet=dui&diam=luctus&in=rutrum&magna=nulla&bibendum=tellus&imperdiet=in&nullam=sagittis&orci=dui&pede=vel&venenatis=nisl&non=duis&sodales=ac&sed=nibh&tincidunt=fusce",
        Phone = "433-995-6591",
        Email = "jruiltonj@homestead.com",
        Description = "vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "REMEDYREPACK INC.",
        Hours = "M-F: 6AM - 3PM",
        Services = "general medicine, operation, checkups",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://w3.org/metus/vitae/ipsum.xml?nisl=odio&ut=cras&volutpat=mi&sapien=pede&arcu=malesuada&sed=in&augue=imperdiet",
        Phone = "835-877-4809",
        Email = "kudiek@dion.ne.jp",
        Description = "libero non mattis pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla sed vel enim sit amet nunc viverra dapibus nulla suscipit ligula in lacus curabitur at ipsum ac tellus semper interdum mauris ullamcorper"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "ALK-Abello, Inc.",
        Hours = "M-F: 1AM - 4PM",
        Services = "Support, scans, operation",
        EligibilityRequirements = "Age, Income",
        Website = "http://va.gov/sapien/cursus.json?morbi=suspendisse&quis=potenti&tortor=cras&id=in&nulla=purus&ultrices=eu",
        Phone = "732-721-8889",
        Email = "cmarvenl@yale.edu",
        Description = "condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam cras pellentesque volutpat dui maecenas tristique est et tempus semper est quam pharetra magna ac consequat metus sapien ut nunc vestibulum"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Fresh, Inc.",
        Hours = "M-F: 0AM - 2PM",
        Services = "operation, outpatient procedures, checkups",
        EligibilityRequirements = "Location, Insurance",
        Website = "http://mac.com/ipsum/primis/in/faucibus/orci/luctus.png?justo=duis&sollicitudin=aliquam&ut=convallis&suscipit=nunc&a=proin&feugiat=at&et=turpis&eros=a&vestibulum=pede&ac=posuere&est=nonummy&lacinia=integer&nisi=non&venenatis=velit&tristique=donec&fusce=diam&congue=neque&diam=vestibulum&id=eget&ornare=vulputate",
        Phone = "152-529-9887",
        Email = "ddugganm@umn.edu",
        Description = "eget eros elementum pellentesque quisque porta volutpat erat quisque erat eros viverra eget congue eget semper rutrum nulla nunc purus phasellus in felis donec semper sapien a libero nam dui proin leo odio"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Contract Pharmacy Services-PA",
        Hours = "M-F: 8AM - 3PM",
        Services = "general medicine, exams, scans",
        EligibilityRequirements = "Income, Insurance",
        Website = "https://microsoft.com/ac/enim/in.aspx?pharetra=tempus&magna=vivamus&ac=in&consequat=felis&metus=eu&sapien=sapien&ut=cursus&nunc=vestibulum&vestibulum=proin&ante=eu&ipsum=mi&primis=nulla&in=ac&faucibus=enim&orci=in&luctus=tempor&et=turpis&ultrices=nec&posuere=euismod&cubilia=scelerisque&curae=quam&mauris=turpis&viverra=adipiscing&diam=lorem&vitae=vitae&quam=mattis&suspendisse=nibh&potenti=ligula&nullam=nec&porttitor=sem&lacus=duis&at=aliquam&turpis=convallis&donec=nunc&posuere=proin&metus=at&vitae=turpis&ipsum=a&aliquam=pede&non=posuere&mauris=nonummy&morbi=integer&non=non&lectus=velit&aliquam=donec&sit=diam&amet=neque&diam=vestibulum&in=eget&magna=vulputate&bibendum=ut&imperdiet=ultrices&nullam=vel&orci=augue&pede=vestibulum&venenatis=ante&non=ipsum&sodales=primis&sed=in&tincidunt=faucibus&eu=orci&felis=luctus&fusce=et&posuere=ultrices&felis=posuere&sed=cubilia&lacus=curae&morbi=donec&sem=pharetra&mauris=magna&laoreet=vestibulum&ut=aliquet&rhoncus=ultrices",
        Phone = "537-388-1979",
        Email = "asparshattn@t.co",
        Description = "enim blandit mi in porttitor pede justo eu massa donec dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "King Bio Inc.",
        Hours = "M-F: 1AM - 4PM",
        Services = "scans, exams, outpatient procedures",
        EligibilityRequirements = "Location, Insurance",
        Website = "http://naver.com/tristique/in/tempus.xml?maecenas=non&tristique=quam&est=nec&et=dui&tempus=luctus&semper=rutrum&est=nulla&quam=tellus&pharetra=in&magna=sagittis&ac=dui&consequat=vel&metus=nisl&sapien=duis&ut=ac&nunc=nibh&vestibulum=fusce&ante=lacus&ipsum=purus&primis=aliquet&in=at&faucibus=feugiat&orci=non&luctus=pretium&et=quis&ultrices=lectus&posuere=suspendisse&cubilia=potenti&curae=in&mauris=eleifend&viverra=quam&diam=a&vitae=odio&quam=in&suspendisse=hac&potenti=habitasse&nullam=platea",
        Phone = "162-871-4276",
        Email = "isweeneyo@house.gov",
        Description = "rhoncus mauris enim leo rhoncus sed vestibulum sit amet cursus id turpis integer aliquet massa id lobortis convallis tortor risus dapibus augue vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "CVS Pharmacy",
        Hours = "M-F: 4AM - 4PM",
        Services = "checkups, scans, Support",
        EligibilityRequirements = "Income, Age",
        Website = "http://hud.gov/parturient/montes/nascetur/ridiculus/mus/etiam/vel.js?in=eleifend&congue=quam&etiam=a&justo=odio&etiam=in&pretium=hac&iaculis=habitasse&justo=platea&in=dictumst&hac=maecenas&habitasse=ut&platea=massa&dictumst=quis&etiam=augue&faucibus=luctus&cursus=tincidunt&urna=nulla&ut=mollis&tellus=molestie&nulla=lorem&ut=quisque&erat=ut&id=erat&mauris=curabitur&vulputate=gravida&elementum=nisi&nullam=at&varius=nibh&nulla=in&facilisi=hac&cras=habitasse&non=platea&velit=dictumst&nec=aliquam&nisi=augue&vulputate=quam&nonummy=sollicitudin&maecenas=vitae&tincidunt=consectetuer&lacus=eget&at=rutrum&velit=at&vivamus=lorem&vel=integer&nulla=tincidunt&eget=ante&eros=vel&elementum=ipsum&pellentesque=praesent&quisque=blandit&porta=lacinia&volutpat=erat&erat=vestibulum&quisque=sed",
        Phone = "618-532-1305",
        Email = "hbircherp@fc2.com",
        Description = "sed ante vivamus tortor duis mattis egestas metus aenean fermentum donec ut mauris eget massa tempor convallis nulla neque libero convallis eget eleifend luctus ultricies eu nibh quisque id justo sit amet sapien dignissim vestibulum vestibulum ante ipsum"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "U.S. Pharmaceuticals",
        Hours = "M-F: 2AM - 5PM",
        Services = "exams, Support, operation",
        EligibilityRequirements = "Location, Income",
        Website = "http://1und1.de/vestibulum/velit.jpg?ipsum=donec&praesent=odio&blandit=justo&lacinia=sollicitudin&erat=ut&vestibulum=suscipit&sed=a&magna=feugiat&at=et&nunc=eros&commodo=vestibulum&placerat=ac&praesent=est&blandit=lacinia&nam=nisi&nulla=venenatis&integer=tristique&pede=fusce&justo=congue&lacinia=diam&eget=id&tincidunt=ornare&eget=imperdiet&tempus=sapien&vel=urna&pede=pretium&morbi=nisl&porttitor=ut&lorem=volutpat&id=sapien&ligula=arcu&suspendisse=sed&ornare=augue&consequat=aliquam&lectus=erat&in=volutpat&est=in&risus=congue&auctor=etiam&sed=justo&tristique=etiam&in=pretium&tempus=iaculis&sit=justo&amet=in&sem=hac&fusce=habitasse&consequat=platea&nulla=dictumst&nisl=etiam&nunc=faucibus&nisl=cursus&duis=urna&bibendum=ut&felis=tellus&sed=nulla",
        Phone = "949-199-1198",
        Email = "mmcilwaineq@wiley.com",
        Description = "donec dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "REMEDYREPACK INC.",
        Hours = "M-F: 7AM - 5PM",
        Services = "scans, operation, Support",
        EligibilityRequirements = "Income, Location",
        Website = "http://oakley.com/eget/tempus.xml?praesent=massa&id=donec&massa=dapibus&id=duis&nisl=at&venenatis=velit&lacinia=eu&aenean=est&sit=congue&amet=elementum&justo=in&morbi=hac&ut=habitasse&odio=platea&cras=dictumst&mi=morbi&pede=vestibulum&malesuada=velit&in=id&imperdiet=pretium&et=iaculis&commodo=diam&vulputate=erat&justo=fermentum&in=justo&blandit=nec&ultrices=condimentum&enim=neque&lorem=sapien&ipsum=placerat&dolor=ante&sit=nulla&amet=justo&consectetuer=aliquam&adipiscing=quis&elit=turpis&proin=eget&interdum=elit&mauris=sodales&non=scelerisque&ligula=mauris&pellentesque=sit&ultrices=amet&phasellus=eros&id=suspendisse&sapien=accumsan&in=tortor&sapien=quis&iaculis=turpis&congue=sed&vivamus=ante&metus=vivamus&arcu=tortor&adipiscing=duis&molestie=mattis&hendrerit=egestas&at=metus&vulputate=aenean&vitae=fermentum&nisl=donec&aenean=ut&lectus=mauris&pellentesque=eget&eget=massa&nunc=tempor&donec=convallis&quis=nulla&orci=neque&eget=libero&orci=convallis&vehicula=eget",
        Phone = "308-509-9953",
        Email = "cgeffenr@joomla.org",
        Description = "convallis nunc proin at turpis a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Alcon Laboratories, Inc",
        Hours = "M-F: 4AM - 7PM",
        Services = "outpatient procedures, operation, exams",
        EligibilityRequirements = "Income, Insurance",
        Website = "http://cpanel.net/sem.xml?ultrices=ligula&aliquet=suspendisse&maecenas=ornare&leo=consequat&odio=lectus&condimentum=in&id=est&luctus=risus&nec=auctor&molestie=sed&sed=tristique&justo=in&pellentesque=tempus&viverra=sit&pede=amet&ac=sem&diam=fusce&cras=consequat&pellentesque=nulla&volutpat=nisl&dui=nunc&maecenas=nisl&tristique=duis&est=bibendum&et=felis&tempus=sed&semper=interdum&est=venenatis&quam=turpis&pharetra=enim&magna=blandit&ac=mi&consequat=in&metus=porttitor&sapien=pede&ut=justo&nunc=eu&vestibulum=massa&ante=donec&ipsum=dapibus&primis=duis&in=at&faucibus=velit&orci=eu&luctus=est&et=congue&ultrices=elementum&posuere=in&cubilia=hac&curae=habitasse&mauris=platea&viverra=dictumst&diam=morbi&vitae=vestibulum&quam=velit&suspendisse=id&potenti=pretium&nullam=iaculis&porttitor=diam&lacus=erat&at=fermentum&turpis=justo&donec=nec&posuere=condimentum&metus=neque&vitae=sapien&ipsum=placerat&aliquam=ante&non=nulla&mauris=justo&morbi=aliquam&non=quis&lectus=turpis&aliquam=eget&sit=elit&amet=sodales&diam=scelerisque&in=mauris&magna=sit&bibendum=amet&imperdiet=eros&nullam=suspendisse",
        Phone = "546-770-4469",
        Email = "ahymerss@bloglovin.com",
        Description = "tortor id nulla ultrices aliquet maecenas leo odio condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam cras pellentesque volutpat dui maecenas tristique est et tempus"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Paddock Laboratories, Inc.",
        Hours = "M-F: 4AM - 6PM",
        Services = "Support, operation, checkups",
        EligibilityRequirements = "Insurance, Income",
        Website = "http://squidoo.com/penatibus/et/magnis/dis/parturient.xml?metus=iaculis&arcu=diam&adipiscing=erat&molestie=fermentum&hendrerit=justo&at=nec&vulputate=condimentum&vitae=neque&nisl=sapien&aenean=placerat&lectus=ante&pellentesque=nulla&eget=justo&nunc=aliquam&donec=quis&quis=turpis&orci=eget&eget=elit&orci=sodales&vehicula=scelerisque&condimentum=mauris&curabitur=sit&in=amet&libero=eros&ut=suspendisse&massa=accumsan&volutpat=tortor&convallis=quis&morbi=turpis&odio=sed&odio=ante&elementum=vivamus&eu=tortor&interdum=duis&eu=mattis&tincidunt=egestas&in=metus&leo=aenean&maecenas=fermentum&pulvinar=donec&lobortis=ut&est=mauris&phasellus=eget&sit=massa&amet=tempor&erat=convallis&nulla=nulla&tempus=neque&vivamus=libero&in=convallis&felis=eget&eu=eleifend&sapien=luctus&cursus=ultricies&vestibulum=eu&proin=nibh&eu=quisque&mi=id",
        Phone = "954-503-2167",
        Email = "gbont@springer.com",
        Description = "faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend donec ut dolor morbi vel lectus in quam"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "JHP Pharmaceuticals, LLC",
        Hours = "M-F: 5AM - 5PM",
        Services = "checkups, operation, exams",
        EligibilityRequirements = "Location, Age",
        Website = "http://surveymonkey.com/amet/nunc/viverra.aspx?gravida=sollicitudin&nisi=mi&at=sit&nibh=amet&in=lobortis&hac=sapien&habitasse=sapien&platea=non&dictumst=mi&aliquam=integer&augue=ac&quam=neque&sollicitudin=duis&vitae=bibendum&consectetuer=morbi&eget=non&rutrum=quam&at=nec&lorem=dui&integer=luctus&tincidunt=rutrum&ante=nulla&vel=tellus&ipsum=in&praesent=sagittis&blandit=dui&lacinia=vel&erat=nisl&vestibulum=duis&sed=ac&magna=nibh&at=fusce&nunc=lacus&commodo=purus&placerat=aliquet&praesent=at&blandit=feugiat&nam=non&nulla=pretium&integer=quis&pede=lectus&justo=suspendisse&lacinia=potenti&eget=in&tincidunt=eleifend&eget=quam&tempus=a&vel=odio&pede=in&morbi=hac&porttitor=habitasse&lorem=platea&id=dictumst&ligula=maecenas&suspendisse=ut&ornare=massa&consequat=quis&lectus=augue&in=luctus&est=tincidunt&risus=nulla&auctor=mollis&sed=molestie&tristique=lorem&in=quisque&tempus=ut&sit=erat&amet=curabitur&sem=gravida&fusce=nisi&consequat=at&nulla=nibh&nisl=in&nunc=hac&nisl=habitasse&duis=platea",
        Phone = "236-780-4174",
        Email = "cwilsteadu@vistaprint.com",
        Description = "erat quisque erat eros viverra eget congue eget semper rutrum nulla nunc purus phasellus in felis donec semper sapien a libero nam dui proin leo odio porttitor id consequat in consequat ut"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Procter & Gamble Manufacturing Co.",
        Hours = "M-F: 3AM - 5PM",
        Services = "general medicine, outpatient procedures, scans",
        EligibilityRequirements = "Income, Insurance",
        Website = "http://trellian.com/libero/nullam/sit/amet/turpis.xml?convallis=blandit&duis=ultrices&consequat=enim&dui=lorem&nec=ipsum&nisi=dolor&volutpat=sit&eleifend=amet&donec=consectetuer&ut=adipiscing&dolor=elit&morbi=proin&vel=interdum&lectus=mauris&in=non&quam=ligula&fringilla=pellentesque&rhoncus=ultrices&mauris=phasellus&enim=id&leo=sapien&rhoncus=in&sed=sapien&vestibulum=iaculis&sit=congue&amet=vivamus&cursus=metus&id=arcu&turpis=adipiscing&integer=molestie&aliquet=hendrerit&massa=at&id=vulputate&lobortis=vitae&convallis=nisl&tortor=aenean&risus=lectus&dapibus=pellentesque&augue=eget&vel=nunc&accumsan=donec&tellus=quis&nisi=orci&eu=eget&orci=orci&mauris=vehicula&lacinia=condimentum&sapien=curabitur&quis=in&libero=libero&nullam=ut&sit=massa&amet=volutpat&turpis=convallis&elementum=morbi&ligula=odio&vehicula=odio&consequat=elementum&morbi=eu&a=interdum&ipsum=eu&integer=tincidunt&a=in&nibh=leo&in=maecenas&quis=pulvinar&justo=lobortis&maecenas=est&rhoncus=phasellus&aliquam=sit&lacus=amet&morbi=erat&quis=nulla&tortor=tempus&id=vivamus&nulla=in",
        Phone = "645-242-2514",
        Email = "tleheudev@surveymonkey.com",
        Description = "sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper porta volutpat quam pede lobortis ligula sit amet eleifend pede libero quis orci nullam molestie"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Straight Arrow Products, Inc.",
        Hours = "M-F: 8AM - 4PM",
        Services = "scans, exams, checkups",
        EligibilityRequirements = "Income, Insurance",
        Website = "http://last.fm/nulla/pede/ullamcorper.jpg?sed=placerat&sagittis=praesent&nam=blandit&congue=nam&risus=nulla&semper=integer&porta=pede&volutpat=justo&quam=lacinia&pede=eget&lobortis=tincidunt&ligula=eget&sit=tempus&amet=vel&eleifend=pede&pede=morbi&libero=porttitor&quis=lorem&orci=id&nullam=ligula&molestie=suspendisse&nibh=ornare&in=consequat&lectus=lectus&pellentesque=in&at=est&nulla=risus&suspendisse=auctor&potenti=sed&cras=tristique&in=in&purus=tempus&eu=sit&magna=amet",
        Phone = "202-163-5695",
        Email = "yvedekhovw@discuz.net",
        Description = "lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu sed augue aliquam erat volutpat in congue etiam justo etiam pretium"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Novartis Pharmaceuticals Corporation",
        Hours = "M-F: 4AM - 6PM",
        Services = "Support, outpatient procedures, exams",
        EligibilityRequirements = "Income, Age",
        Website = "https://nih.gov/non/pretium/quis.html?cubilia=quam&curae=fringilla&donec=rhoncus&pharetra=mauris&magna=enim&vestibulum=leo&aliquet=rhoncus&ultrices=sed&erat=vestibulum&tortor=sit&sollicitudin=amet&mi=cursus&sit=id&amet=turpis&lobortis=integer&sapien=aliquet&sapien=massa&non=id&mi=lobortis&integer=convallis&ac=tortor&neque=risus&duis=dapibus&bibendum=augue&morbi=vel&non=accumsan&quam=tellus&nec=nisi&dui=eu&luctus=orci&rutrum=mauris&nulla=lacinia&tellus=sapien&in=quis&sagittis=libero&dui=nullam",
        Phone = "533-492-3445",
        Email = "vgurneyx@hhs.gov",
        Description = "sit amet erat nulla tempus vivamus in felis eu sapien cursus vestibulum proin eu mi nulla ac enim in tempor turpis nec euismod scelerisque quam"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Paramesh Banerji Life Sciences LLC",
        Hours = "M-F: 2AM - 8PM",
        Services = "checkups, exams, general medicine",
        EligibilityRequirements = "Insurance, Age",
        Website = "http://studiopress.com/iaculis/diam/erat/fermentum/justo/nec/condimentum.jpg?donec=a&ut=pede&mauris=posuere&eget=nonummy&massa=integer&tempor=non&convallis=velit&nulla=donec&neque=diam&libero=neque&convallis=vestibulum&eget=eget&eleifend=vulputate&luctus=ut&ultricies=ultrices&eu=vel&nibh=augue&quisque=vestibulum&id=ante&justo=ipsum&sit=primis&amet=in&sapien=faucibus&dignissim=orci&vestibulum=luctus&vestibulum=et&ante=ultrices&ipsum=posuere&primis=cubilia&in=curae&faucibus=donec&orci=pharetra&luctus=magna&et=vestibulum&ultrices=aliquet&posuere=ultrices&cubilia=erat&curae=tortor&nulla=sollicitudin&dapibus=mi&dolor=sit&vel=amet&est=lobortis&donec=sapien&odio=sapien&justo=non&sollicitudin=mi&ut=integer&suscipit=ac&a=neque&feugiat=duis&et=bibendum&eros=morbi&vestibulum=non&ac=quam&est=nec&lacinia=dui&nisi=luctus&venenatis=rutrum&tristique=nulla&fusce=tellus&congue=in&diam=sagittis&id=dui&ornare=vel&imperdiet=nisl&sapien=duis&urna=ac&pretium=nibh&nisl=fusce&ut=lacus&volutpat=purus&sapien=aliquet&arcu=at&sed=feugiat&augue=non&aliquam=pretium&erat=quis&volutpat=lectus",
        Phone = "332-691-9998",
        Email = "acollerany@godaddy.com",
        Description = "sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper porta"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Mission Hills S.A de C.V",
        Hours = "M-F: 3AM - 5PM",
        Services = "outpatient procedures, operation, exams",
        EligibilityRequirements = "Age, Insurance",
        Website = "https://independent.co.uk/nulla/suscipit/ligula/in/lacus/curabitur.png?donec=dignissim&dapibus=vestibulum&duis=vestibulum&at=ante&velit=ipsum&eu=primis&est=in&congue=faucibus&elementum=orci&in=luctus&hac=et&habitasse=ultrices&platea=posuere&dictumst=cubilia&morbi=curae&vestibulum=nulla&velit=dapibus&id=dolor&pretium=vel&iaculis=est&diam=donec&erat=odio&fermentum=justo&justo=sollicitudin&nec=ut&condimentum=suscipit&neque=a&sapien=feugiat&placerat=et&ante=eros&nulla=vestibulum&justo=ac&aliquam=est&quis=lacinia&turpis=nisi&eget=venenatis&elit=tristique&sodales=fusce&scelerisque=congue&mauris=diam&sit=id&amet=ornare&eros=imperdiet&suspendisse=sapien&accumsan=urna&tortor=pretium&quis=nisl&turpis=ut&sed=volutpat&ante=sapien&vivamus=arcu&tortor=sed&duis=augue&mattis=aliquam&egestas=erat&metus=volutpat&aenean=in&fermentum=congue&donec=etiam&ut=justo&mauris=etiam",
        Phone = "262-866-2201",
        Email = "obaldingz@tripod.com",
        Description = "nam dui proin leo odio porttitor id consequat in consequat ut nulla sed accumsan felis ut at dolor quis odio consequat varius integer ac leo pellentesque ultrices mattis odio donec"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "SJ Creations, Inc.",
        Hours = "M-F: 6AM - 2PM",
        Services = "operation, scans, checkups",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://cpanel.net/justo/sit/amet/sapien/dignissim.png?non=nunc&sodales=nisl&sed=duis&tincidunt=bibendum&eu=felis&felis=sed&fusce=interdum&posuere=venenatis&felis=turpis&sed=enim&lacus=blandit&morbi=mi&sem=in&mauris=porttitor&laoreet=pede&ut=justo&rhoncus=eu&aliquet=massa&pulvinar=donec&sed=dapibus&nisl=duis&nunc=at&rhoncus=velit&dui=eu&vel=est&sem=congue&sed=elementum&sagittis=in&nam=hac&congue=habitasse&risus=platea&semper=dictumst&porta=morbi&volutpat=vestibulum&quam=velit&pede=id&lobortis=pretium&ligula=iaculis&sit=diam&amet=erat&eleifend=fermentum&pede=justo&libero=nec&quis=condimentum&orci=neque&nullam=sapien&molestie=placerat&nibh=ante&in=nulla&lectus=justo&pellentesque=aliquam&at=quis&nulla=turpis&suspendisse=eget&potenti=elit&cras=sodales&in=scelerisque&purus=mauris&eu=sit&magna=amet&vulputate=eros&luctus=suspendisse&cum=accumsan&sociis=tortor&natoque=quis&penatibus=turpis&et=sed&magnis=ante&dis=vivamus&parturient=tortor&montes=duis&nascetur=mattis&ridiculus=egestas&mus=metus&vivamus=aenean&vestibulum=fermentum&sagittis=donec&sapien=ut&cum=mauris&sociis=eget&natoque=massa&penatibus=tempor&et=convallis&magnis=nulla&dis=neque&parturient=libero&montes=convallis&nascetur=eget&ridiculus=eleifend&mus=luctus&etiam=ultricies&vel=eu&augue=nibh&vestibulum=quisque&rutrum=id&rutrum=justo",
        Phone = "456-795-7665",
        Email = "ahollindale10@cyberchimps.com",
        Description = "primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et eros"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Cargus International, Inc.",
        Hours = "M-F: 1AM - 3PM",
        Services = "checkups, Support, exams",
        EligibilityRequirements = "Age, Insurance",
        Website = "http://dagondesign.com/porttitor/lorem.png?nulla=vivamus&eget=tortor&eros=duis&elementum=mattis&pellentesque=egestas&quisque=metus&porta=aenean&volutpat=fermentum&erat=donec&quisque=ut&erat=mauris&eros=eget&viverra=massa&eget=tempor&congue=convallis&eget=nulla&semper=neque&rutrum=libero&nulla=convallis&nunc=eget&purus=eleifend&phasellus=luctus&in=ultricies&felis=eu&donec=nibh&semper=quisque&sapien=id&a=justo&libero=sit&nam=amet&dui=sapien&proin=dignissim&leo=vestibulum&odio=vestibulum&porttitor=ante&id=ipsum&consequat=primis&in=in&consequat=faucibus&ut=orci&nulla=luctus&sed=et&accumsan=ultrices&felis=posuere&ut=cubilia&at=curae&dolor=nulla&quis=dapibus&odio=dolor&consequat=vel&varius=est&integer=donec&ac=odio&leo=justo",
        Phone = "258-228-5707",
        Email = "mfernandez11@51.la",
        Description = "pede justo eu massa donec dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "CVS Pharmacy",
        Hours = "M-F: 0AM - 6PM",
        Services = "outpatient procedures, general medicine, checkups",
        EligibilityRequirements = "Insurance, Age",
        Website = "https://wikispaces.com/eu/massa/donec/dapibus/duis/at/velit.aspx?ipsum=at&aliquam=feugiat&non=non&mauris=pretium&morbi=quis&non=lectus&lectus=suspendisse&aliquam=potenti&sit=in&amet=eleifend&diam=quam&in=a&magna=odio&bibendum=in&imperdiet=hac&nullam=habitasse&orci=platea&pede=dictumst&venenatis=maecenas&non=ut&sodales=massa&sed=quis&tincidunt=augue&eu=luctus&felis=tincidunt&fusce=nulla&posuere=mollis&felis=molestie&sed=lorem&lacus=quisque&morbi=ut&sem=erat&mauris=curabitur&laoreet=gravida&ut=nisi&rhoncus=at&aliquet=nibh&pulvinar=in&sed=hac&nisl=habitasse&nunc=platea&rhoncus=dictumst&dui=aliquam&vel=augue&sem=quam&sed=sollicitudin&sagittis=vitae&nam=consectetuer&congue=eget&risus=rutrum&semper=at&porta=lorem&volutpat=integer&quam=tincidunt&pede=ante&lobortis=vel&ligula=ipsum&sit=praesent&amet=blandit&eleifend=lacinia&pede=erat&libero=vestibulum&quis=sed&orci=magna&nullam=at&molestie=nunc&nibh=commodo&in=placerat&lectus=praesent&pellentesque=blandit&at=nam&nulla=nulla&suspendisse=integer&potenti=pede&cras=justo",
        Phone = "547-175-4188",
        Email = "hbangs12@scientificamerican.com",
        Description = "praesent blandit nam nulla integer pede justo lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit amet sem fusce consequat"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Physicians Total Care, Inc.",
        Hours = "M-F: 5AM - 4PM",
        Services = "Support, operation, outpatient procedures",
        EligibilityRequirements = "Income, Location",
        Website = "http://senate.gov/vulputate.js?mus=aliquam&etiam=convallis&vel=nunc&augue=proin&vestibulum=at&rutrum=turpis&rutrum=a&neque=pede&aenean=posuere&auctor=nonummy&gravida=integer&sem=non&praesent=velit&id=donec&massa=diam&id=neque&nisl=vestibulum&venenatis=eget&lacinia=vulputate",
        Phone = "675-326-9243",
        Email = "terat13@nytimes.com",
        Description = "nunc proin at turpis a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Richmond Division of Wyeth",
        Hours = "M-F: 0AM - 9PM",
        Services = "general medicine, checkups, outpatient procedures",
        EligibilityRequirements = "Location, Income",
        Website = "http://goodreads.com/sapien/dignissim/vestibulum/vestibulum.js?tempus=in&sit=faucibus&amet=orci&sem=luctus&fusce=et&consequat=ultrices&nulla=posuere&nisl=cubilia&nunc=curae&nisl=mauris&duis=viverra&bibendum=diam&felis=vitae&sed=quam&interdum=suspendisse&venenatis=potenti&turpis=nullam&enim=porttitor&blandit=lacus&mi=at&in=turpis&porttitor=donec&pede=posuere&justo=metus&eu=vitae&massa=ipsum&donec=aliquam&dapibus=non&duis=mauris&at=morbi&velit=non&eu=lectus&est=aliquam&congue=sit&elementum=amet&in=diam&hac=in&habitasse=magna&platea=bibendum&dictumst=imperdiet&morbi=nullam&vestibulum=orci&velit=pede&id=venenatis&pretium=non&iaculis=sodales&diam=sed&erat=tincidunt&fermentum=eu&justo=felis&nec=fusce&condimentum=posuere&neque=felis&sapien=sed&placerat=lacus&ante=morbi&nulla=sem&justo=mauris&aliquam=laoreet&quis=ut&turpis=rhoncus&eget=aliquet&elit=pulvinar&sodales=sed&scelerisque=nisl&mauris=nunc&sit=rhoncus&amet=dui&eros=vel&suspendisse=sem&accumsan=sed&tortor=sagittis&quis=nam&turpis=congue&sed=risus&ante=semper&vivamus=porta&tortor=volutpat&duis=quam&mattis=pede&egestas=lobortis&metus=ligula&aenean=sit&fermentum=amet&donec=eleifend&ut=pede&mauris=libero&eget=quis&massa=orci&tempor=nullam&convallis=molestie",
        Phone = "517-254-1766",
        Email = "dbremen14@sciencedirect.com",
        Description = "consectetuer adipiscing elit proin risus praesent lectus vestibulum quam sapien varius ut blandit non interdum in ante vestibulum ante ipsum primis in"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "CorePharma, LLC",
        Hours = "M-F: 7AM - 3PM",
        Services = "checkups, exams, scans",
        EligibilityRequirements = "Income, Location",
        Website = "http://cbslocal.com/vulputate/luctus.html?ultrices=primis&enim=in&lorem=faucibus&ipsum=orci&dolor=luctus&sit=et&amet=ultrices&consectetuer=posuere&adipiscing=cubilia&elit=curae&proin=nulla&interdum=dapibus&mauris=dolor&non=vel&ligula=est&pellentesque=donec&ultrices=odio&phasellus=justo&id=sollicitudin&sapien=ut&in=suscipit&sapien=a&iaculis=feugiat&congue=et&vivamus=eros&metus=vestibulum&arcu=ac&adipiscing=est&molestie=lacinia&hendrerit=nisi&at=venenatis&vulputate=tristique&vitae=fusce&nisl=congue&aenean=diam&lectus=id&pellentesque=ornare&eget=imperdiet&nunc=sapien&donec=urna&quis=pretium",
        Phone = "158-336-4141",
        Email = "anutley15@nba.com",
        Description = "quam turpis adipiscing lorem vitae mattis nibh ligula nec sem duis aliquam convallis nunc proin at turpis a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Antigen Laboratories, Inc.",
        Hours = "M-F: 7AM - 2PM",
        Services = "checkups, outpatient procedures, exams",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://paginegialle.it/proin/risus/praesent/lectus.aspx?mus=rhoncus&vivamus=mauris&vestibulum=enim&sagittis=leo&sapien=rhoncus&cum=sed&sociis=vestibulum&natoque=sit&penatibus=amet&et=cursus&magnis=id&dis=turpis&parturient=integer&montes=aliquet&nascetur=massa&ridiculus=id&mus=lobortis&etiam=convallis&vel=tortor&augue=risus&vestibulum=dapibus&rutrum=augue&rutrum=vel&neque=accumsan&aenean=tellus&auctor=nisi&gravida=eu&sem=orci&praesent=mauris&id=lacinia&massa=sapien&id=quis&nisl=libero&venenatis=nullam&lacinia=sit&aenean=amet&sit=turpis&amet=elementum&justo=ligula&morbi=vehicula&ut=consequat&odio=morbi&cras=a&mi=ipsum&pede=integer&malesuada=a&in=nibh&imperdiet=in&et=quis&commodo=justo&vulputate=maecenas&justo=rhoncus&in=aliquam&blandit=lacus&ultrices=morbi&enim=quis&lorem=tortor&ipsum=id&dolor=nulla&sit=ultrices&amet=aliquet&consectetuer=maecenas",
        Phone = "656-761-8074",
        Email = "syitshak16@wired.com",
        Description = "donec odio justo sollicitudin ut suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna pretium nisl ut volutpat"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Lake Erie Medical & Surgical Supply DBA Quality Care Products LLC",
        Hours = "M-F: 4AM - 1PM",
        Services = "outpatient procedures, operation, Support",
        EligibilityRequirements = "Income, Location",
        Website = "http://time.com/velit/eu/est.json?ut=accumsan&blandit=odio&non=curabitur&interdum=convallis&in=duis&ante=consequat&vestibulum=dui&ante=nec&ipsum=nisi&primis=volutpat&in=eleifend&faucibus=donec&orci=ut&luctus=dolor&et=morbi&ultrices=vel&posuere=lectus&cubilia=in&curae=quam&duis=fringilla&faucibus=rhoncus&accumsan=mauris&odio=enim&curabitur=leo&convallis=rhoncus&duis=sed&consequat=vestibulum&dui=sit&nec=amet&nisi=cursus&volutpat=id&eleifend=turpis&donec=integer&ut=aliquet&dolor=massa&morbi=id&vel=lobortis&lectus=convallis&in=tortor&quam=risus&fringilla=dapibus&rhoncus=augue&mauris=vel&enim=accumsan&leo=tellus&rhoncus=nisi&sed=eu&vestibulum=orci&sit=mauris&amet=lacinia&cursus=sapien&id=quis&turpis=libero&integer=nullam&aliquet=sit&massa=amet&id=turpis&lobortis=elementum&convallis=ligula",
        Phone = "118-380-5537",
        Email = "kbernaert17@t-online.de",
        Description = "ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac neque duis bibendum morbi non"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Ranbaxy Pharmaceuticals Inc",
        Hours = "M-F: 9AM - 8PM",
        Services = "operation, scans, checkups",
        EligibilityRequirements = "Age, Location",
        Website = "https://nytimes.com/quis/turpis/eget/elit/sodales.js?eros=libero&viverra=convallis&eget=eget&congue=eleifend&eget=luctus&semper=ultricies&rutrum=eu&nulla=nibh&nunc=quisque&purus=id&phasellus=justo&in=sit&felis=amet&donec=sapien&semper=dignissim&sapien=vestibulum&a=vestibulum&libero=ante&nam=ipsum&dui=primis&proin=in&leo=faucibus&odio=orci&porttitor=luctus&id=et&consequat=ultrices&in=posuere&consequat=cubilia&ut=curae&nulla=nulla&sed=dapibus&accumsan=dolor&felis=vel&ut=est&at=donec&dolor=odio&quis=justo&odio=sollicitudin&consequat=ut",
        Phone = "122-990-3291",
        Email = "bdezamora18@reverbnation.com",
        Description = "elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio condimentum id"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Aidarex Pharmaceuticals LLC",
        Hours = "M-F: 6AM - 0PM",
        Services = "exams, general medicine, scans",
        EligibilityRequirements = "Income, Age",
        Website = "https://goo.gl/metus/vitae/ipsum/aliquam/non/mauris/morbi.xml?porta=pharetra&volutpat=magna&quam=vestibulum&pede=aliquet&lobortis=ultrices&ligula=erat&sit=tortor&amet=sollicitudin&eleifend=mi&pede=sit&libero=amet&quis=lobortis&orci=sapien&nullam=sapien&molestie=non&nibh=mi&in=integer&lectus=ac&pellentesque=neque&at=duis&nulla=bibendum&suspendisse=morbi&potenti=non&cras=quam&in=nec&purus=dui&eu=luctus&magna=rutrum&vulputate=nulla&luctus=tellus&cum=in&sociis=sagittis&natoque=dui&penatibus=vel&et=nisl&magnis=duis&dis=ac&parturient=nibh&montes=fusce&nascetur=lacus&ridiculus=purus&mus=aliquet&vivamus=at&vestibulum=feugiat&sagittis=non&sapien=pretium&cum=quis&sociis=lectus&natoque=suspendisse&penatibus=potenti&et=in&magnis=eleifend&dis=quam&parturient=a&montes=odio&nascetur=in&ridiculus=hac&mus=habitasse&etiam=platea&vel=dictumst&augue=maecenas&vestibulum=ut&rutrum=massa&rutrum=quis&neque=augue",
        Phone = "882-210-7708",
        Email = "calben19@comsenz.com",
        Description = "ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Mylan Institutional Inc.",
        Hours = "M-F: 6AM - 0PM",
        Services = "operation, scans, exams",
        EligibilityRequirements = "Income, Insurance",
        Website = "http://wikispaces.com/penatibus/et/magnis/dis/parturient.js?neque=velit&aenean=id&auctor=pretium&gravida=iaculis&sem=diam&praesent=erat&id=fermentum&massa=justo&id=nec&nisl=condimentum&venenatis=neque&lacinia=sapien&aenean=placerat&sit=ante&amet=nulla&justo=justo&morbi=aliquam&ut=quis&odio=turpis&cras=eget&mi=elit&pede=sodales&malesuada=scelerisque&in=mauris&imperdiet=sit&et=amet&commodo=eros&vulputate=suspendisse&justo=accumsan&in=tortor&blandit=quis&ultrices=turpis&enim=sed&lorem=ante&ipsum=vivamus&dolor=tortor&sit=duis&amet=mattis&consectetuer=egestas&adipiscing=metus&elit=aenean&proin=fermentum&interdum=donec&mauris=ut&non=mauris&ligula=eget&pellentesque=massa&ultrices=tempor&phasellus=convallis&id=nulla&sapien=neque&in=libero&sapien=convallis&iaculis=eget&congue=eleifend&vivamus=luctus&metus=ultricies&arcu=eu&adipiscing=nibh&molestie=quisque&hendrerit=id&at=justo&vulputate=sit&vitae=amet",
        Phone = "554-374-8970",
        Email = "nhoworth1a@opera.com",
        Description = "dolor sit amet consectetuer adipiscing elit proin interdum mauris non ligula pellentesque ultrices phasellus id sapien in sapien iaculis congue vivamus metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Rebel Distributors Corp.",
        Hours = "M-F: 3AM - 4PM",
        Services = "exams, outpatient procedures, operation",
        EligibilityRequirements = "Location, Insurance",
        Website = "http://google.com.hk/in/faucibus/orci.html?at=eros&lorem=elementum&integer=pellentesque&tincidunt=quisque&ante=porta&vel=volutpat&ipsum=erat&praesent=quisque&blandit=erat&lacinia=eros&erat=viverra&vestibulum=eget&sed=congue&magna=eget&at=semper&nunc=rutrum&commodo=nulla&placerat=nunc&praesent=purus&blandit=phasellus&nam=in&nulla=felis&integer=donec&pede=semper&justo=sapien&lacinia=a&eget=libero&tincidunt=nam&eget=dui&tempus=proin&vel=leo&pede=odio&morbi=porttitor&porttitor=id&lorem=consequat&id=in&ligula=consequat&suspendisse=ut&ornare=nulla&consequat=sed&lectus=accumsan&in=felis&est=ut&risus=at&auctor=dolor&sed=quis&tristique=odio&in=consequat&tempus=varius&sit=integer&amet=ac&sem=leo&fusce=pellentesque&consequat=ultrices&nulla=mattis&nisl=odio&nunc=donec&nisl=vitae&duis=nisi&bibendum=nam&felis=ultrices&sed=libero&interdum=non&venenatis=mattis&turpis=pulvinar&enim=nulla&blandit=pede&mi=ullamcorper&in=augue&porttitor=a&pede=suscipit&justo=nulla&eu=elit&massa=ac&donec=nulla&dapibus=sed&duis=vel&at=enim&velit=sit&eu=amet&est=nunc&congue=viverra&elementum=dapibus",
        Phone = "268-380-8356",
        Email = "adudlestone1b@utexas.edu",
        Description = "turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio condimentum id"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "AMERICAN SALES COMPANY",
        Hours = "M-F: 5AM - 1PM",
        Services = "general medicine, checkups, scans",
        EligibilityRequirements = "Income, Insurance",
        Website = "http://usa.gov/interdum/in/ante/vestibulum/ante/ipsum/primis.json?feugiat=nulla&non=nisl&pretium=nunc&quis=nisl&lectus=duis&suspendisse=bibendum&potenti=felis&in=sed&eleifend=interdum&quam=venenatis&a=turpis&odio=enim&in=blandit&hac=mi&habitasse=in&platea=porttitor&dictumst=pede&maecenas=justo&ut=eu&massa=massa&quis=donec&augue=dapibus&luctus=duis&tincidunt=at&nulla=velit&mollis=eu&molestie=est&lorem=congue&quisque=elementum&ut=in&erat=hac&curabitur=habitasse&gravida=platea&nisi=dictumst&at=morbi&nibh=vestibulum&in=velit&hac=id&habitasse=pretium&platea=iaculis&dictumst=diam&aliquam=erat&augue=fermentum&quam=justo&sollicitudin=nec&vitae=condimentum&consectetuer=neque&eget=sapien&rutrum=placerat&at=ante&lorem=nulla&integer=justo&tincidunt=aliquam&ante=quis&vel=turpis&ipsum=eget&praesent=elit&blandit=sodales&lacinia=scelerisque&erat=mauris&vestibulum=sit&sed=amet",
        Phone = "535-477-8164",
        Email = "gpickavant1c@cloudflare.com",
        Description = "vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Topco Associates LLC",
        Hours = "M-F: 0AM - 4PM",
        Services = "exams, outpatient procedures, scans",
        EligibilityRequirements = "Age, Insurance",
        Website = "http://dyndns.org/rhoncus/dui/vel/sem/sed/sagittis/nam.jsp?leo=viverra&maecenas=pede&pulvinar=ac&lobortis=diam&est=cras&phasellus=pellentesque&sit=volutpat&amet=dui&erat=maecenas&nulla=tristique&tempus=est&vivamus=et&in=tempus&felis=semper&eu=est&sapien=quam&cursus=pharetra&vestibulum=magna&proin=ac&eu=consequat&mi=metus&nulla=sapien&ac=ut&enim=nunc&in=vestibulum&tempor=ante&turpis=ipsum&nec=primis&euismod=in&scelerisque=faucibus&quam=orci&turpis=luctus&adipiscing=et&lorem=ultrices&vitae=posuere&mattis=cubilia&nibh=curae&ligula=mauris&nec=viverra&sem=diam&duis=vitae&aliquam=quam&convallis=suspendisse&nunc=potenti&proin=nullam&at=porttitor&turpis=lacus&a=at&pede=turpis&posuere=donec&nonummy=posuere&integer=metus&non=vitae&velit=ipsum&donec=aliquam&diam=non&neque=mauris&vestibulum=morbi&eget=non&vulputate=lectus&ut=aliquam&ultrices=sit&vel=amet&augue=diam",
        Phone = "519-386-7035",
        Email = "gbartolomeu1d@imdb.com",
        Description = "sed lacus morbi sem mauris laoreet ut rhoncus aliquet pulvinar sed nisl nunc rhoncus dui vel sem sed sagittis nam congue risus semper porta volutpat quam pede lobortis ligula sit"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Have and Be Co., Ltd.",
        Hours = "M-F: 6AM - 5PM",
        Services = "checkups, operation, Support",
        EligibilityRequirements = "Age, Income",
        Website = "https://nydailynews.com/sed/tristique/in/tempus/sit/amet.aspx?velit=ridiculus&donec=mus&diam=vivamus&neque=vestibulum&vestibulum=sagittis&eget=sapien&vulputate=cum&ut=sociis&ultrices=natoque&vel=penatibus&augue=et&vestibulum=magnis&ante=dis&ipsum=parturient&primis=montes&in=nascetur&faucibus=ridiculus&orci=mus&luctus=etiam&et=vel&ultrices=augue&posuere=vestibulum&cubilia=rutrum&curae=rutrum&donec=neque&pharetra=aenean&magna=auctor&vestibulum=gravida&aliquet=sem&ultrices=praesent&erat=id&tortor=massa&sollicitudin=id&mi=nisl&sit=venenatis&amet=lacinia&lobortis=aenean&sapien=sit&sapien=amet&non=justo&mi=morbi&integer=ut&ac=odio&neque=cras&duis=mi&bibendum=pede&morbi=malesuada&non=in&quam=imperdiet&nec=et&dui=commodo&luctus=vulputate",
        Phone = "439-873-1616",
        Email = "openton1e@dion.ne.jp",
        Description = "nec nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat quisque erat eros viverra eget congue eget semper rutrum nulla nunc purus phasellus in felis donec"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Gensavis Pharmaceuticals, LLC",
        Hours = "M-F: 9AM - 6PM",
        Services = "checkups, Support, scans",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://issuu.com/a/ipsum/integer/a.js?leo=sed&odio=vestibulum&condimentum=sit&id=amet&luctus=cursus&nec=id&molestie=turpis&sed=integer&justo=aliquet&pellentesque=massa&viverra=id&pede=lobortis&ac=convallis&diam=tortor&cras=risus&pellentesque=dapibus&volutpat=augue&dui=vel&maecenas=accumsan&tristique=tellus&est=nisi&et=eu",
        Phone = "467-711-7893",
        Email = "nfellgate1f@apache.org",
        Description = "ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra diam vitae quam suspendisse potenti nullam porttitor lacus at turpis donec posuere metus vitae"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Sigmapharm Laboratories, LLC",
        Hours = "M-F: 7AM - 6PM",
        Services = "general medicine, checkups, exams",
        EligibilityRequirements = "Income, Age",
        Website = "http://prnewswire.com/bibendum/felis.js?quis=platea&libero=dictumst&nullam=maecenas&sit=ut&amet=massa&turpis=quis&elementum=augue&ligula=luctus&vehicula=tincidunt&consequat=nulla&morbi=mollis&a=molestie&ipsum=lorem&integer=quisque&a=ut&nibh=erat&in=curabitur&quis=gravida&justo=nisi&maecenas=at&rhoncus=nibh&aliquam=in&lacus=hac&morbi=habitasse&quis=platea&tortor=dictumst&id=aliquam&nulla=augue&ultrices=quam&aliquet=sollicitudin&maecenas=vitae&leo=consectetuer&odio=eget&condimentum=rutrum&id=at&luctus=lorem&nec=integer&molestie=tincidunt&sed=ante&justo=vel&pellentesque=ipsum&viverra=praesent&pede=blandit&ac=lacinia&diam=erat&cras=vestibulum&pellentesque=sed&volutpat=magna&dui=at&maecenas=nunc&tristique=commodo&est=placerat&et=praesent&tempus=blandit&semper=nam&est=nulla&quam=integer&pharetra=pede&magna=justo&ac=lacinia&consequat=eget&metus=tincidunt&sapien=eget&ut=tempus",
        Phone = "658-945-8109",
        Email = "ireuss1g@twitter.com",
        Description = "a odio in hac habitasse platea dictumst maecenas ut massa quis augue luctus tincidunt nulla mollis molestie lorem quisque ut erat curabitur gravida nisi at nibh in hac habitasse platea dictumst aliquam augue quam"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Nelco Laboratories, Inc.",
        Hours = "M-F: 4AM - 8PM",
        Services = "outpatient procedures, scans, checkups",
        EligibilityRequirements = "Age, Location",
        Website = "https://meetup.com/id/justo.jpg?accumsan=rutrum&odio=at&curabitur=lorem&convallis=integer&duis=tincidunt&consequat=ante&dui=vel&nec=ipsum&nisi=praesent&volutpat=blandit&eleifend=lacinia&donec=erat&ut=vestibulum&dolor=sed&morbi=magna&vel=at&lectus=nunc&in=commodo&quam=placerat&fringilla=praesent&rhoncus=blandit&mauris=nam&enim=nulla&leo=integer&rhoncus=pede",
        Phone = "733-985-7897",
        Email = "rtinline1h@slashdot.org",
        Description = "eu massa donec dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Falcon Pharmaceuticals",
        Hours = "M-F: 4AM - 9PM",
        Services = "checkups, exams, outpatient procedures",
        EligibilityRequirements = "Age, Insurance",
        Website = "https://ifeng.com/augue/vel/accumsan/tellus.xml?at=habitasse&velit=platea&vivamus=dictumst&vel=morbi&nulla=vestibulum&eget=velit&eros=id&elementum=pretium&pellentesque=iaculis&quisque=diam&porta=erat&volutpat=fermentum&erat=justo&quisque=nec&erat=condimentum&eros=neque&viverra=sapien&eget=placerat&congue=ante&eget=nulla&semper=justo&rutrum=aliquam&nulla=quis&nunc=turpis&purus=eget&phasellus=elit&in=sodales&felis=scelerisque&donec=mauris&semper=sit&sapien=amet&a=eros&libero=suspendisse&nam=accumsan&dui=tortor&proin=quis&leo=turpis&odio=sed&porttitor=ante&id=vivamus&consequat=tortor&in=duis",
        Phone = "881-896-0941",
        Email = "ekryszka1i@weibo.com",
        Description = "velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Teva Pharmaceuticals USA Inc",
        Hours = "M-F: 2AM - 0PM",
        Services = "operation, general medicine, checkups",
        EligibilityRequirements = "Income, Insurance",
        Website = "http://naver.com/nonummy/maecenas/tincidunt.jsp?ac=sit&nibh=amet&fusce=consectetuer&lacus=adipiscing&purus=elit&aliquet=proin&at=risus&feugiat=praesent&non=lectus&pretium=vestibulum&quis=quam&lectus=sapien&suspendisse=varius&potenti=ut&in=blandit&eleifend=non&quam=interdum&a=in&odio=ante&in=vestibulum",
        Phone = "285-223-8566",
        Email = "rdemongeot1j@storify.com",
        Description = "pellentesque at nulla suspendisse potenti cras in purus eu magna vulputate luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Nelco Laboratories, Inc.",
        Hours = "M-F: 5AM - 6PM",
        Services = "checkups, exams, outpatient procedures",
        EligibilityRequirements = "Insurance, Age",
        Website = "https://sitemeter.com/eget/massa/tempor.html?vulputate=mattis&luctus=egestas&cum=metus&sociis=aenean&natoque=fermentum&penatibus=donec&et=ut&magnis=mauris&dis=eget&parturient=massa",
        Phone = "441-245-7361",
        Email = "snevill1k@howstuffworks.com",
        Description = "sollicitudin ut suscipit a feugiat et eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna pretium nisl ut volutpat sapien arcu"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Innocutis Holding LLC",
        Hours = "M-F: 0AM - 8PM",
        Services = "Support, scans, checkups",
        EligibilityRequirements = "Insurance, Age",
        Website = "https://pagesperso-orange.fr/eros/viverra.js?lacus=elementum&curabitur=ligula&at=vehicula&ipsum=consequat&ac=morbi&tellus=a&semper=ipsum&interdum=integer&mauris=a&ullamcorper=nibh&purus=in&sit=quis&amet=justo&nulla=maecenas&quisque=rhoncus&arcu=aliquam&libero=lacus&rutrum=morbi&ac=quis&lobortis=tortor&vel=id&dapibus=nulla&at=ultrices&diam=aliquet&nam=maecenas&tristique=leo&tortor=odio&eu=condimentum&pede=id",
        Phone = "720-927-7862",
        Email = "aleprovost1l@cam.ac.uk",
        Description = "platea dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo aliquam quis turpis eget elit"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "ALK-Abello, Inc.",
        Hours = "M-F: 7AM - 1PM",
        Services = "scans, checkups, operation",
        EligibilityRequirements = "Insurance, Income",
        Website = "https://ifeng.com/vestibulum/eget/vulputate/ut.xml?id=integer&mauris=aliquet&vulputate=massa&elementum=id&nullam=lobortis&varius=convallis&nulla=tortor&facilisi=risus&cras=dapibus",
        Phone = "932-422-8604",
        Email = "aburker1m@tripadvisor.com",
        Description = "quis tortor id nulla ultrices aliquet maecenas leo odio condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam cras"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "CVS",
        Hours = "M-F: 8AM - 8PM",
        Services = "checkups, scans, outpatient procedures",
        EligibilityRequirements = "Insurance, Location",
        Website = "https://ucla.edu/posuere/cubilia/curae.json?suspendisse=augue&potenti=aliquam&cras=erat&in=volutpat&purus=in&eu=congue&magna=etiam&vulputate=justo&luctus=etiam&cum=pretium&sociis=iaculis&natoque=justo&penatibus=in&et=hac&magnis=habitasse&dis=platea&parturient=dictumst&montes=etiam&nascetur=faucibus&ridiculus=cursus&mus=urna&vivamus=ut&vestibulum=tellus&sagittis=nulla&sapien=ut&cum=erat&sociis=id&natoque=mauris&penatibus=vulputate&et=elementum&magnis=nullam&dis=varius&parturient=nulla&montes=facilisi&nascetur=cras&ridiculus=non&mus=velit&etiam=nec&vel=nisi&augue=vulputate&vestibulum=nonummy&rutrum=maecenas&rutrum=tincidunt&neque=lacus&aenean=at&auctor=velit&gravida=vivamus&sem=vel&praesent=nulla&id=eget&massa=eros&id=elementum&nisl=pellentesque&venenatis=quisque&lacinia=porta&aenean=volutpat&sit=erat&amet=quisque&justo=erat&morbi=eros&ut=viverra&odio=eget&cras=congue&mi=eget&pede=semper&malesuada=rutrum&in=nulla&imperdiet=nunc&et=purus&commodo=phasellus&vulputate=in&justo=felis&in=donec&blandit=semper&ultrices=sapien&enim=a&lorem=libero&ipsum=nam&dolor=dui&sit=proin&amet=leo&consectetuer=odio&adipiscing=porttitor&elit=id&proin=consequat&interdum=in&mauris=consequat&non=ut&ligula=nulla&pellentesque=sed&ultrices=accumsan&phasellus=felis&id=ut&sapien=at&in=dolor&sapien=quis&iaculis=odio",
        Phone = "154-174-7763",
        Email = "gashbey1n@google.cn",
        Description = "ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices aliquet"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Wal-Mart Stores Inc",
        Hours = "M-F: 6AM - 7PM",
        Services = "scans, operation, outpatient procedures",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://un.org/vulputate/elementum/nullam/varius.html?pharetra=porttitor&magna=pede&ac=justo&consequat=eu&metus=massa&sapien=donec&ut=dapibus&nunc=duis&vestibulum=at",
        Phone = "593-769-4771",
        Email = "eclubley1o@marketwatch.com",
        Description = "neque libero convallis eget eleifend luctus ultricies eu nibh quisque id justo sit amet sapien dignissim vestibulum vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Dispensing Solutions, Inc.",
        Hours = "M-F: 1AM - 7PM",
        Services = "checkups, outpatient procedures, Support",
        EligibilityRequirements = "Location, Insurance",
        Website = "http://skyrock.com/ipsum/integer/a/nibh/in/quis/justo.png?sapien=sit&sapien=amet&non=turpis&mi=elementum&integer=ligula&ac=vehicula&neque=consequat&duis=morbi&bibendum=a&morbi=ipsum&non=integer&quam=a&nec=nibh&dui=in&luctus=quis&rutrum=justo&nulla=maecenas&tellus=rhoncus&in=aliquam&sagittis=lacus&dui=morbi&vel=quis&nisl=tortor&duis=id&ac=nulla&nibh=ultrices&fusce=aliquet&lacus=maecenas&purus=leo&aliquet=odio&at=condimentum&feugiat=id&non=luctus&pretium=nec&quis=molestie&lectus=sed&suspendisse=justo&potenti=pellentesque&in=viverra&eleifend=pede&quam=ac&a=diam&odio=cras&in=pellentesque&hac=volutpat&habitasse=dui&platea=maecenas&dictumst=tristique&maecenas=est&ut=et&massa=tempus&quis=semper&augue=est&luctus=quam&tincidunt=pharetra&nulla=magna&mollis=ac&molestie=consequat&lorem=metus&quisque=sapien&ut=ut&erat=nunc&curabitur=vestibulum&gravida=ante&nisi=ipsum&at=primis&nibh=in&in=faucibus&hac=orci&habitasse=luctus&platea=et&dictumst=ultrices&aliquam=posuere&augue=cubilia&quam=curae&sollicitudin=mauris&vitae=viverra",
        Phone = "474-421-0102",
        Email = "cbedrosian1p@artisteer.com",
        Description = "amet lobortis sapien sapien non mi integer ac neque duis bibendum morbi non quam nec dui luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh fusce lacus purus"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Lake Erie Medical & Surgical Supply DBA Quality Care Products LLC",
        Hours = "M-F: 9AM - 5PM",
        Services = "exams, Support, operation",
        EligibilityRequirements = "Insurance, Income",
        Website = "https://squarespace.com/vel/lectus.js?id=faucibus&sapien=accumsan&in=odio&sapien=curabitur&iaculis=convallis&congue=duis&vivamus=consequat&metus=dui&arcu=nec&adipiscing=nisi&molestie=volutpat&hendrerit=eleifend&at=donec&vulputate=ut&vitae=dolor&nisl=morbi&aenean=vel&lectus=lectus&pellentesque=in&eget=quam&nunc=fringilla&donec=rhoncus&quis=mauris&orci=enim&eget=leo&orci=rhoncus&vehicula=sed&condimentum=vestibulum&curabitur=sit&in=amet&libero=cursus&ut=id&massa=turpis&volutpat=integer&convallis=aliquet&morbi=massa&odio=id&odio=lobortis&elementum=convallis&eu=tortor&interdum=risus&eu=dapibus&tincidunt=augue&in=vel&leo=accumsan&maecenas=tellus&pulvinar=nisi&lobortis=eu&est=orci&phasellus=mauris&sit=lacinia&amet=sapien&erat=quis&nulla=libero&tempus=nullam&vivamus=sit&in=amet&felis=turpis&eu=elementum&sapien=ligula&cursus=vehicula&vestibulum=consequat&proin=morbi&eu=a&mi=ipsum&nulla=integer&ac=a&enim=nibh&in=in&tempor=quis&turpis=justo&nec=maecenas&euismod=rhoncus&scelerisque=aliquam&quam=lacus",
        Phone = "327-299-7863",
        Email = "jcustance1q@xrea.com",
        Description = "platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at nunc commodo placerat praesent blandit nam nulla integer pede justo lacinia eget tincidunt"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Meijer Distribution Inc",
        Hours = "M-F: 2AM - 6PM",
        Services = "operation, Support, checkups",
        EligibilityRequirements = "Age, Income",
        Website = "https://imageshack.us/penatibus/et/magnis/dis/parturient.json?adipiscing=risus&molestie=semper&hendrerit=porta&at=volutpat&vulputate=quam&vitae=pede&nisl=lobortis&aenean=ligula&lectus=sit&pellentesque=amet&eget=eleifend&nunc=pede&donec=libero&quis=quis&orci=orci&eget=nullam&orci=molestie&vehicula=nibh&condimentum=in&curabitur=lectus&in=pellentesque&libero=at&ut=nulla&massa=suspendisse&volutpat=potenti&convallis=cras&morbi=in&odio=purus&odio=eu&elementum=magna&eu=vulputate&interdum=luctus&eu=cum&tincidunt=sociis&in=natoque&leo=penatibus&maecenas=et&pulvinar=magnis&lobortis=dis&est=parturient&phasellus=montes&sit=nascetur&amet=ridiculus&erat=mus&nulla=vivamus&tempus=vestibulum&vivamus=sagittis&in=sapien&felis=cum&eu=sociis&sapien=natoque&cursus=penatibus&vestibulum=et&proin=magnis&eu=dis&mi=parturient&nulla=montes&ac=nascetur&enim=ridiculus&in=mus&tempor=etiam&turpis=vel&nec=augue&euismod=vestibulum&scelerisque=rutrum&quam=rutrum&turpis=neque&adipiscing=aenean&lorem=auctor&vitae=gravida&mattis=sem&nibh=praesent&ligula=id&nec=massa&sem=id&duis=nisl&aliquam=venenatis&convallis=lacinia",
        Phone = "943-855-8961",
        Email = "cmurcott1r@moonfruit.com",
        Description = "neque duis bibendum morbi non quam nec dui luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti in"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "A-S Medication Solutions LLC",
        Hours = "M-F: 4AM - 1PM",
        Services = "exams, Support, scans",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://bizjournals.com/curae.html?mollis=id&molestie=pretium&lorem=iaculis&quisque=diam",
        Phone = "459-619-6316",
        Email = "mlongshaw1s@mapquest.com",
        Description = "id sapien in sapien iaculis congue vivamus metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc donec quis orci eget orci vehicula condimentum curabitur in libero ut massa volutpat convallis morbi odio odio elementum"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Mylan Pharmaceuticals Inc.",
        Hours = "M-F: 1AM - 5PM",
        Services = "general medicine, checkups, exams",
        EligibilityRequirements = "Location, Income",
        Website = "http://symantec.com/non/quam/nec/dui.xml?consectetuer=aenean&eget=fermentum&rutrum=donec&at=ut&lorem=mauris&integer=eget&tincidunt=massa&ante=tempor&vel=convallis&ipsum=nulla&praesent=neque&blandit=libero&lacinia=convallis&erat=eget&vestibulum=eleifend&sed=luctus&magna=ultricies&at=eu&nunc=nibh&commodo=quisque&placerat=id&praesent=justo&blandit=sit&nam=amet&nulla=sapien&integer=dignissim&pede=vestibulum&justo=vestibulum&lacinia=ante&eget=ipsum&tincidunt=primis&eget=in&tempus=faucibus&vel=orci&pede=luctus&morbi=et&porttitor=ultrices&lorem=posuere&id=cubilia&ligula=curae&suspendisse=nulla&ornare=dapibus&consequat=dolor&lectus=vel&in=est&est=donec&risus=odio&auctor=justo&sed=sollicitudin&tristique=ut&in=suscipit&tempus=a&sit=feugiat&amet=et&sem=eros",
        Phone = "617-447-5882",
        Email = "btitmuss1t@discuz.net",
        Description = "luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti in"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Pharmacia and Upjohn Company",
        Hours = "M-F: 0AM - 4PM",
        Services = "Support, scans, outpatient procedures",
        EligibilityRequirements = "Income, Age",
        Website = "http://berkeley.edu/maecenas/leo/odio/condimentum/id/luctus.png?iaculis=curae&justo=nulla&in=dapibus&hac=dolor&habitasse=vel&platea=est&dictumst=donec&etiam=odio&faucibus=justo&cursus=sollicitudin&urna=ut&ut=suscipit&tellus=a&nulla=feugiat&ut=et&erat=eros&id=vestibulum&mauris=ac&vulputate=est",
        Phone = "170-167-7985",
        Email = "ycolgrave1u@usnews.com",
        Description = "quis turpis eget elit sodales scelerisque mauris sit amet eros suspendisse accumsan tortor quis turpis sed ante vivamus tortor duis mattis egestas metus aenean fermentum donec ut mauris"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Wal-Mart Stores Inc",
        Hours = "M-F: 3AM - 6PM",
        Services = "general medicine, scans, Support",
        EligibilityRequirements = "Income, Location",
        Website = "https://accuweather.com/maecenas.png?a=in&nibh=ante&in=vestibulum&quis=ante&justo=ipsum&maecenas=primis&rhoncus=in&aliquam=faucibus&lacus=orci&morbi=luctus&quis=et&tortor=ultrices&id=posuere&nulla=cubilia&ultrices=curae&aliquet=duis&maecenas=faucibus&leo=accumsan&odio=odio&condimentum=curabitur&id=convallis&luctus=duis&nec=consequat&molestie=dui&sed=nec&justo=nisi&pellentesque=volutpat&viverra=eleifend&pede=donec&ac=ut&diam=dolor&cras=morbi&pellentesque=vel&volutpat=lectus&dui=in&maecenas=quam&tristique=fringilla&est=rhoncus&et=mauris&tempus=enim&semper=leo&est=rhoncus&quam=sed&pharetra=vestibulum&magna=sit&ac=amet&consequat=cursus&metus=id&sapien=turpis&ut=integer&nunc=aliquet&vestibulum=massa&ante=id&ipsum=lobortis&primis=convallis&in=tortor&faucibus=risus&orci=dapibus&luctus=augue&et=vel&ultrices=accumsan&posuere=tellus&cubilia=nisi&curae=eu&mauris=orci&viverra=mauris&diam=lacinia&vitae=sapien&quam=quis&suspendisse=libero&potenti=nullam&nullam=sit&porttitor=amet&lacus=turpis&at=elementum&turpis=ligula&donec=vehicula&posuere=consequat&metus=morbi&vitae=a&ipsum=ipsum&aliquam=integer&non=a&mauris=nibh&morbi=in&non=quis&lectus=justo&aliquam=maecenas&sit=rhoncus&amet=aliquam",
        Phone = "312-278-9835",
        Email = "eanchor1v@loc.gov",
        Description = "integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Velocity Pharma",
        Hours = "M-F: 5AM - 5PM",
        Services = "exams, outpatient procedures, scans",
        EligibilityRequirements = "Income, Location",
        Website = "https://oaic.gov.au/vestibulum/rutrum/rutrum/neque/aenean/auctor.jpg?ut=nulla&suscipit=ut&a=erat&feugiat=id&et=mauris&eros=vulputate&vestibulum=elementum&ac=nullam&est=varius&lacinia=nulla&nisi=facilisi&venenatis=cras&tristique=non&fusce=velit&congue=nec&diam=nisi&id=vulputate&ornare=nonummy&imperdiet=maecenas&sapien=tincidunt&urna=lacus&pretium=at&nisl=velit&ut=vivamus&volutpat=vel&sapien=nulla&arcu=eget&sed=eros&augue=elementum&aliquam=pellentesque&erat=quisque&volutpat=porta&in=volutpat&congue=erat&etiam=quisque&justo=erat&etiam=eros&pretium=viverra&iaculis=eget&justo=congue&in=eget&hac=semper&habitasse=rutrum&platea=nulla&dictumst=nunc&etiam=purus&faucibus=phasellus&cursus=in&urna=felis&ut=donec&tellus=semper&nulla=sapien&ut=a&erat=libero&id=nam&mauris=dui&vulputate=proin&elementum=leo&nullam=odio&varius=porttitor&nulla=id&facilisi=consequat&cras=in&non=consequat&velit=ut&nec=nulla&nisi=sed&vulputate=accumsan&nonummy=felis&maecenas=ut&tincidunt=at&lacus=dolor&at=quis&velit=odio&vivamus=consequat&vel=varius&nulla=integer&eget=ac&eros=leo&elementum=pellentesque&pellentesque=ultrices&quisque=mattis",
        Phone = "209-131-1399",
        Email = "hpatria1w@trellian.com",
        Description = "habitasse platea dictumst etiam faucibus cursus urna ut tellus nulla ut erat id mauris vulputate elementum nullam varius nulla facilisi cras non velit nec nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Antigen Laboratories, Inc.",
        Hours = "M-F: 2AM - 3PM",
        Services = "general medicine, checkups, exams",
        EligibilityRequirements = "Insurance, Location",
        Website = "http://about.me/sed.jsp?urna=cursus&ut=urna&tellus=ut&nulla=tellus&ut=nulla&erat=ut&id=erat&mauris=id&vulputate=mauris&elementum=vulputate&nullam=elementum&varius=nullam&nulla=varius&facilisi=nulla&cras=facilisi&non=cras&velit=non&nec=velit&nisi=nec&vulputate=nisi&nonummy=vulputate&maecenas=nonummy&tincidunt=maecenas&lacus=tincidunt&at=lacus&velit=at&vivamus=velit&vel=vivamus&nulla=vel&eget=nulla&eros=eget&elementum=eros&pellentesque=elementum&quisque=pellentesque&porta=quisque&volutpat=porta&erat=volutpat&quisque=erat&erat=quisque&eros=erat&viverra=eros&eget=viverra&congue=eget&eget=congue&semper=eget&rutrum=semper&nulla=rutrum&nunc=nulla&purus=nunc&phasellus=purus&in=phasellus&felis=in",
        Phone = "585-912-0430",
        Email = "lbalsdon1x@weibo.com",
        Description = "consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices aliquet maecenas leo odio condimentum id luctus nec molestie sed justo pellentesque viverra pede ac diam cras pellentesque volutpat dui"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "ALK-Abello, Inc.",
        Hours = "M-F: 5AM - 2PM",
        Services = "checkups, general medicine, scans",
        EligibilityRequirements = "Location, Age",
        Website = "https://berkeley.edu/nisl/venenatis/lacinia/aenean/sit/amet.json?vel=tempus&enim=vel&sit=pede&amet=morbi&nunc=porttitor&viverra=lorem&dapibus=id&nulla=ligula&suscipit=suspendisse&ligula=ornare&in=consequat",
        Phone = "591-253-4863",
        Email = "rgarrals1y@sciencedaily.com",
        Description = "in tempus sit amet sem fusce consequat nulla nisl nunc nisl duis bibendum felis sed interdum venenatis turpis enim blandit mi in porttitor pede justo eu massa donec dapibus duis at"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Washington Homeopathic Products",
        Hours = "M-F: 1AM - 9PM",
        Services = "general medicine, outpatient procedures, checkups",
        EligibilityRequirements = "Location, Age",
        Website = "http://de.vu/molestie/hendrerit/at.jpg?mi=sed&pede=nisl&malesuada=nunc&in=rhoncus&imperdiet=dui&et=vel&commodo=sem&vulputate=sed&justo=sagittis&in=nam&blandit=congue&ultrices=risus&enim=semper&lorem=porta&ipsum=volutpat&dolor=quam&sit=pede&amet=lobortis&consectetuer=ligula&adipiscing=sit&elit=amet&proin=eleifend&interdum=pede&mauris=libero&non=quis&ligula=orci&pellentesque=nullam&ultrices=molestie&phasellus=nibh&id=in&sapien=lectus&in=pellentesque&sapien=at&iaculis=nulla&congue=suspendisse&vivamus=potenti&metus=cras&arcu=in&adipiscing=purus&molestie=eu&hendrerit=magna&at=vulputate&vulputate=luctus&vitae=cum&nisl=sociis&aenean=natoque&lectus=penatibus&pellentesque=et&eget=magnis&nunc=dis&donec=parturient&quis=montes&orci=nascetur&eget=ridiculus&orci=mus&vehicula=vivamus&condimentum=vestibulum&curabitur=sagittis&in=sapien&libero=cum&ut=sociis&massa=natoque&volutpat=penatibus&convallis=et&morbi=magnis&odio=dis&odio=parturient&elementum=montes&eu=nascetur&interdum=ridiculus&eu=mus&tincidunt=etiam&in=vel&leo=augue&maecenas=vestibulum&pulvinar=rutrum&lobortis=rutrum&est=neque&phasellus=aenean&sit=auctor&amet=gravida&erat=sem&nulla=praesent&tempus=id&vivamus=massa",
        Phone = "835-560-8675",
        Email = "mgrahlman1z@walmart.com",
        Description = "et tempus semper est quam pharetra magna ac consequat metus sapien ut nunc vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae mauris viverra"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Healthlink",
        Hours = "M-F: 6AM - 6PM",
        Services = "checkups, scans, Support",
        EligibilityRequirements = "Age, Income",
        Website = "https://pagesperso-orange.fr/pede/ullamcorper/augue/a.js?et=convallis&ultrices=morbi&posuere=odio&cubilia=odio&curae=elementum&mauris=eu&viverra=interdum&diam=eu&vitae=tincidunt&quam=in&suspendisse=leo&potenti=maecenas&nullam=pulvinar&porttitor=lobortis&lacus=est&at=phasellus&turpis=sit&donec=amet&posuere=erat&metus=nulla&vitae=tempus&ipsum=vivamus&aliquam=in&non=felis&mauris=eu&morbi=sapien&non=cursus&lectus=vestibulum&aliquam=proin&sit=eu&amet=mi&diam=nulla&in=ac&magna=enim&bibendum=in&imperdiet=tempor&nullam=turpis&orci=nec&pede=euismod&venenatis=scelerisque&non=quam&sodales=turpis&sed=adipiscing&tincidunt=lorem&eu=vitae&felis=mattis&fusce=nibh&posuere=ligula&felis=nec&sed=sem&lacus=duis&morbi=aliquam&sem=convallis&mauris=nunc&laoreet=proin&ut=at&rhoncus=turpis&aliquet=a&pulvinar=pede&sed=posuere&nisl=nonummy&nunc=integer&rhoncus=non&dui=velit&vel=donec&sem=diam&sed=neque&sagittis=vestibulum&nam=eget&congue=vulputate&risus=ut&semper=ultrices&porta=vel&volutpat=augue&quam=vestibulum&pede=ante&lobortis=ipsum&ligula=primis&sit=in&amet=faucibus&eleifend=orci&pede=luctus&libero=et&quis=ultrices&orci=posuere",
        Phone = "758-754-5542",
        Email = "tburless20@technorati.com",
        Description = "metus vitae ipsum aliquam non mauris morbi non lectus aliquam sit amet diam in magna bibendum imperdiet nullam orci pede venenatis non sodales"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "PharmaCare US, Inc.",
        Hours = "M-F: 5AM - 8PM",
        Services = "exams, Support, checkups",
        EligibilityRequirements = "Income, Location",
        Website = "http://macromedia.com/quis/augue/luctus/tincidunt/nulla.html?in=nulla&consequat=tempus&ut=vivamus&nulla=in&sed=felis&accumsan=eu&felis=sapien&ut=cursus&at=vestibulum&dolor=proin&quis=eu&odio=mi&consequat=nulla&varius=ac&integer=enim&ac=in&leo=tempor&pellentesque=turpis&ultrices=nec",
        Phone = "928-907-8077",
        Email = "mantonacci21@vinaora.com",
        Description = "faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac neque duis bibendum morbi non quam nec dui luctus rutrum"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Rebel Distributors Corp.",
        Hours = "M-F: 1AM - 1PM",
        Services = "scans, general medicine, outpatient procedures",
        EligibilityRequirements = "Insurance, Location",
        Website = "http://gnu.org/rutrum/nulla.jpg?lacus=congue&morbi=diam&sem=id&mauris=ornare&laoreet=imperdiet&ut=sapien&rhoncus=urna&aliquet=pretium&pulvinar=nisl&sed=ut&nisl=volutpat&nunc=sapien&rhoncus=arcu&dui=sed&vel=augue&sem=aliquam&sed=erat&sagittis=volutpat&nam=in&congue=congue&risus=etiam&semper=justo&porta=etiam&volutpat=pretium&quam=iaculis&pede=justo&lobortis=in&ligula=hac&sit=habitasse&amet=platea&eleifend=dictumst&pede=etiam&libero=faucibus&quis=cursus&orci=urna&nullam=ut&molestie=tellus&nibh=nulla&in=ut&lectus=erat&pellentesque=id&at=mauris&nulla=vulputate&suspendisse=elementum&potenti=nullam&cras=varius&in=nulla&purus=facilisi&eu=cras&magna=non&vulputate=velit&luctus=nec&cum=nisi&sociis=vulputate&natoque=nonummy&penatibus=maecenas&et=tincidunt&magnis=lacus&dis=at&parturient=velit&montes=vivamus&nascetur=vel&ridiculus=nulla&mus=eget&vivamus=eros&vestibulum=elementum&sagittis=pellentesque&sapien=quisque&cum=porta&sociis=volutpat&natoque=erat",
        Phone = "299-931-5761",
        Email = "swinfindale22@bloglovin.com",
        Description = "vehicula condimentum curabitur in libero ut massa volutpat convallis morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est phasellus sit amet erat nulla tempus"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Ranbaxy Laboratories Inc.",
        Hours = "M-F: 2AM - 6PM",
        Services = "scans, checkups, outpatient procedures",
        EligibilityRequirements = "Age, Insurance",
        Website = "https://surveymonkey.com/in/felis/eu/sapien/cursus.jpg?iaculis=lacus&congue=morbi&vivamus=sem&metus=mauris&arcu=laoreet&adipiscing=ut&molestie=rhoncus&hendrerit=aliquet&at=pulvinar&vulputate=sed&vitae=nisl&nisl=nunc&aenean=rhoncus&lectus=dui&pellentesque=vel&eget=sem&nunc=sed&donec=sagittis&quis=nam&orci=congue&eget=risus&orci=semper&vehicula=porta&condimentum=volutpat&curabitur=quam&in=pede&libero=lobortis&ut=ligula&massa=sit&volutpat=amet&convallis=eleifend&morbi=pede&odio=libero&odio=quis&elementum=orci&eu=nullam&interdum=molestie&eu=nibh&tincidunt=in&in=lectus&leo=pellentesque&maecenas=at&pulvinar=nulla&lobortis=suspendisse&est=potenti&phasellus=cras&sit=in&amet=purus&erat=eu&nulla=magna&tempus=vulputate&vivamus=luctus&in=cum",
        Phone = "620-627-3370",
        Email = "litter23@dailymail.co.uk",
        Description = "porttitor pede justo eu massa donec dapibus duis at velit eu est congue elementum in hac habitasse platea dictumst morbi vestibulum velit id pretium iaculis diam erat fermentum justo nec condimentum neque sapien placerat ante nulla justo"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Burkhart Dental Supply Inc",
        Hours = "M-F: 6AM - 7PM",
        Services = "outpatient procedures, general medicine, checkups",
        EligibilityRequirements = "Location, Insurance",
        Website = "http://eventbrite.com/dapibus/duis/at/velit.json?nulla=aenean&neque=lectus&libero=pellentesque&convallis=eget&eget=nunc&eleifend=donec&luctus=quis&ultricies=orci&eu=eget&nibh=orci&quisque=vehicula&id=condimentum&justo=curabitur&sit=in&amet=libero&sapien=ut&dignissim=massa&vestibulum=volutpat&vestibulum=convallis&ante=morbi&ipsum=odio&primis=odio&in=elementum&faucibus=eu&orci=interdum&luctus=eu&et=tincidunt&ultrices=in&posuere=leo&cubilia=maecenas&curae=pulvinar&nulla=lobortis&dapibus=est&dolor=phasellus&vel=sit&est=amet&donec=erat&odio=nulla&justo=tempus&sollicitudin=vivamus&ut=in&suscipit=felis&a=eu&feugiat=sapien",
        Phone = "826-540-4001",
        Email = "wbligh24@gmpg.org",
        Description = "et magnis dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem praesent id massa id nisl"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Golden State Medical Supply, Inc.",
        Hours = "M-F: 4AM - 8PM",
        Services = "operation, general medicine, checkups",
        EligibilityRequirements = "Age, Location",
        Website = "https://google.it/ante/vestibulum/ante.jpg?cubilia=quam&curae=pede&donec=lobortis&pharetra=ligula&magna=sit&vestibulum=amet&aliquet=eleifend&ultrices=pede&erat=libero&tortor=quis&sollicitudin=orci&mi=nullam&sit=molestie&amet=nibh&lobortis=in&sapien=lectus&sapien=pellentesque&non=at&mi=nulla&integer=suspendisse&ac=potenti&neque=cras&duis=in&bibendum=purus&morbi=eu&non=magna&quam=vulputate&nec=luctus&dui=cum&luctus=sociis&rutrum=natoque&nulla=penatibus&tellus=et&in=magnis&sagittis=dis&dui=parturient&vel=montes&nisl=nascetur&duis=ridiculus&ac=mus&nibh=vivamus&fusce=vestibulum&lacus=sagittis&purus=sapien&aliquet=cum&at=sociis&feugiat=natoque&non=penatibus&pretium=et&quis=magnis&lectus=dis&suspendisse=parturient&potenti=montes",
        Phone = "684-861-6327",
        Email = "lprettyjohns25@yellowbook.com",
        Description = "in felis donec semper sapien a libero nam dui proin leo odio porttitor id consequat in consequat ut nulla sed accumsan felis ut at dolor quis odio"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "PD-Rx Pharmaceuticals, Inc.",
        Hours = "M-F: 7AM - 2PM",
        Services = "scans, general medicine, Support",
        EligibilityRequirements = "Location, Insurance",
        Website = "http://ustream.tv/id/luctus/nec/molestie/sed/justo.json?est=etiam&phasellus=pretium&sit=iaculis&amet=justo&erat=in&nulla=hac&tempus=habitasse&vivamus=platea&in=dictumst&felis=etiam&eu=faucibus&sapien=cursus&cursus=urna&vestibulum=ut&proin=tellus&eu=nulla&mi=ut&nulla=erat&ac=id&enim=mauris&in=vulputate&tempor=elementum&turpis=nullam&nec=varius&euismod=nulla&scelerisque=facilisi&quam=cras&turpis=non&adipiscing=velit&lorem=nec&vitae=nisi&mattis=vulputate&nibh=nonummy&ligula=maecenas&nec=tincidunt&sem=lacus",
        Phone = "379-841-8780",
        Email = "fleibold26@ihg.com",
        Description = "sit amet diam in magna bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Physicians Total Care, Inc.",
        Hours = "M-F: 9AM - 4PM",
        Services = "operation, exams, general medicine",
        EligibilityRequirements = "Insurance, Age",
        Website = "http://soup.io/justo/eu.png?at=a&turpis=feugiat&a=et&pede=eros&posuere=vestibulum&nonummy=ac&integer=est&non=lacinia&velit=nisi&donec=venenatis&diam=tristique&neque=fusce&vestibulum=congue&eget=diam&vulputate=id&ut=ornare&ultrices=imperdiet&vel=sapien&augue=urna&vestibulum=pretium&ante=nisl&ipsum=ut&primis=volutpat&in=sapien&faucibus=arcu&orci=sed&luctus=augue&et=aliquam&ultrices=erat&posuere=volutpat&cubilia=in&curae=congue&donec=etiam&pharetra=justo&magna=etiam&vestibulum=pretium&aliquet=iaculis&ultrices=justo&erat=in&tortor=hac&sollicitudin=habitasse&mi=platea&sit=dictumst&amet=etiam&lobortis=faucibus&sapien=cursus&sapien=urna&non=ut&mi=tellus&integer=nulla&ac=ut&neque=erat&duis=id&bibendum=mauris&morbi=vulputate&non=elementum&quam=nullam&nec=varius&dui=nulla&luctus=facilisi&rutrum=cras&nulla=non&tellus=velit&in=nec&sagittis=nisi&dui=vulputate&vel=nonummy&nisl=maecenas&duis=tincidunt&ac=lacus&nibh=at&fusce=velit&lacus=vivamus&purus=vel&aliquet=nulla&at=eget&feugiat=eros&non=elementum&pretium=pellentesque&quis=quisque&lectus=porta&suspendisse=volutpat&potenti=erat&in=quisque&eleifend=erat&quam=eros&a=viverra&odio=eget&in=congue&hac=eget&habitasse=semper&platea=rutrum&dictumst=nulla&maecenas=nunc&ut=purus&massa=phasellus&quis=in&augue=felis&luctus=donec",
        Phone = "633-222-4621",
        Email = "bheenan27@icq.com",
        Description = "scelerisque quam turpis adipiscing lorem vitae mattis nibh ligula nec sem duis aliquam convallis nunc proin at turpis a pede posuere nonummy integer non velit donec diam neque"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "ScieGen Pharmaceuticals, Inc.",
        Hours = "M-F: 7AM - 4PM",
        Services = "outpatient procedures, exams, Support",
        EligibilityRequirements = "Location, Age",
        Website = "https://feedburner.com/at/velit/eu/est/congue/elementum/in.json?vestibulum=in&sagittis=sapien&sapien=iaculis&cum=congue&sociis=vivamus&natoque=metus",
        Phone = "955-195-7981",
        Email = "gskeermer28@goodreads.com",
        Description = "quisque id justo sit amet sapien dignissim vestibulum vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin ut suscipit a feugiat et eros vestibulum ac"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Space Brands Limited",
        Hours = "M-F: 2AM - 6PM",
        Services = "Support, exams, checkups",
        EligibilityRequirements = "Location, Age",
        Website = "http://cisco.com/elementum.jpg?condimentum=consectetuer&curabitur=eget&in=rutrum&libero=at&ut=lorem&massa=integer&volutpat=tincidunt&convallis=ante&morbi=vel&odio=ipsum&odio=praesent&elementum=blandit&eu=lacinia&interdum=erat&eu=vestibulum&tincidunt=sed&in=magna&leo=at&maecenas=nunc&pulvinar=commodo&lobortis=placerat&est=praesent&phasellus=blandit&sit=nam&amet=nulla&erat=integer&nulla=pede&tempus=justo&vivamus=lacinia&in=eget&felis=tincidunt&eu=eget&sapien=tempus&cursus=vel&vestibulum=pede&proin=morbi&eu=porttitor&mi=lorem&nulla=id&ac=ligula&enim=suspendisse&in=ornare&tempor=consequat&turpis=lectus&nec=in&euismod=est&scelerisque=risus&quam=auctor&turpis=sed&adipiscing=tristique",
        Phone = "235-313-4423",
        Email = "jlambrook29@phoca.cz",
        Description = "sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Caraco Pharmaceutical Laboratories, Ltd.",
        Hours = "M-F: 3AM - 7PM",
        Services = "Support, checkups, exams",
        EligibilityRequirements = "Income, Location",
        Website = "http://nps.gov/praesent/lectus/vestibulum/quam.html?a=vel&odio=augue&in=vestibulum&hac=ante&habitasse=ipsum&platea=primis&dictumst=in&maecenas=faucibus&ut=orci&massa=luctus&quis=et&augue=ultrices&luctus=posuere&tincidunt=cubilia&nulla=curae&mollis=donec&molestie=pharetra&lorem=magna&quisque=vestibulum&ut=aliquet&erat=ultrices&curabitur=erat&gravida=tortor&nisi=sollicitudin&at=mi&nibh=sit&in=amet&hac=lobortis&habitasse=sapien&platea=sapien&dictumst=non&aliquam=mi&augue=integer&quam=ac&sollicitudin=neque&vitae=duis&consectetuer=bibendum&eget=morbi&rutrum=non&at=quam&lorem=nec&integer=dui&tincidunt=luctus&ante=rutrum&vel=nulla&ipsum=tellus&praesent=in&blandit=sagittis&lacinia=dui&erat=vel&vestibulum=nisl&sed=duis&magna=ac&at=nibh&nunc=fusce&commodo=lacus&placerat=purus&praesent=aliquet&blandit=at&nam=feugiat&nulla=non&integer=pretium&pede=quis&justo=lectus&lacinia=suspendisse&eget=potenti&tincidunt=in&eget=eleifend&tempus=quam&vel=a&pede=odio&morbi=in&porttitor=hac&lorem=habitasse&id=platea&ligula=dictumst&suspendisse=maecenas&ornare=ut&consequat=massa&lectus=quis&in=augue&est=luctus&risus=tincidunt&auctor=nulla&sed=mollis&tristique=molestie&in=lorem&tempus=quisque&sit=ut&amet=erat&sem=curabitur&fusce=gravida&consequat=nisi&nulla=at&nisl=nibh&nunc=in",
        Phone = "914-350-5054",
        Email = "sivetts2a@wufoo.com",
        Description = "nulla mollis molestie lorem quisque ut erat curabitur gravida nisi at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Capellon Pharmaceuticals, LLC",
        Hours = "M-F: 4AM - 4PM",
        Services = "operation, checkups, Support",
        EligibilityRequirements = "Insurance, Location",
        Website = "http://purevolume.com/nulla/nunc/purus/phasellus/in/felis.html?sapien=eget&cum=nunc&sociis=donec&natoque=quis&penatibus=orci&et=eget&magnis=orci&dis=vehicula&parturient=condimentum",
        Phone = "713-422-1633",
        Email = "scannop2b@cbslocal.com",
        Description = "a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "The Procter & Gamble Manufacturing Company",
        Hours = "M-F: 7AM - 1PM",
        Services = "operation, Support, exams",
        EligibilityRequirements = "Age, Income",
        Website = "http://weebly.com/etiam/faucibus/cursus.js?consequat=ligula&nulla=vehicula",
        Phone = "374-761-7620",
        Email = "crallings2c@ehow.com",
        Description = "lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices aliquet"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Preferred Pharmaceuticals, Inc",
        Hours = "M-F: 4AM - 7PM",
        Services = "Support, general medicine, exams",
        EligibilityRequirements = "Insurance, Location",
        Website = "http://chronoengine.com/eros/suspendisse/accumsan/tortor.js?sit=ac&amet=leo&sapien=pellentesque&dignissim=ultrices&vestibulum=mattis&vestibulum=odio&ante=donec&ipsum=vitae&primis=nisi&in=nam&faucibus=ultrices&orci=libero&luctus=non&et=mattis&ultrices=pulvinar&posuere=nulla&cubilia=pede&curae=ullamcorper&nulla=augue&dapibus=a&dolor=suscipit",
        Phone = "572-416-6638",
        Email = "ngibberd2d@studiopress.com",
        Description = "penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem praesent id massa id"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Dispensing Solutions, Inc.",
        Hours = "M-F: 3AM - 3PM",
        Services = "checkups, general medicine, outpatient procedures",
        EligibilityRequirements = "Income, Insurance",
        Website = "https://craigslist.org/nulla/integer/pede/justo/lacinia.aspx?etiam=suspendisse&justo=potenti&etiam=nullam&pretium=porttitor&iaculis=lacus&justo=at&in=turpis&hac=donec&habitasse=posuere&platea=metus&dictumst=vitae&etiam=ipsum&faucibus=aliquam&cursus=non&urna=mauris&ut=morbi&tellus=non&nulla=lectus&ut=aliquam&erat=sit&id=amet&mauris=diam&vulputate=in&elementum=magna&nullam=bibendum&varius=imperdiet&nulla=nullam&facilisi=orci&cras=pede&non=venenatis&velit=non&nec=sodales&nisi=sed&vulputate=tincidunt&nonummy=eu&maecenas=felis&tincidunt=fusce&lacus=posuere&at=felis&velit=sed&vivamus=lacus&vel=morbi&nulla=sem&eget=mauris&eros=laoreet&elementum=ut&pellentesque=rhoncus&quisque=aliquet&porta=pulvinar&volutpat=sed&erat=nisl&quisque=nunc&erat=rhoncus&eros=dui&viverra=vel&eget=sem&congue=sed&eget=sagittis&semper=nam&rutrum=congue&nulla=risus&nunc=semper&purus=porta&phasellus=volutpat",
        Phone = "475-515-6056",
        Email = "imarl2e@fotki.com",
        Description = "odio consequat varius integer ac leo pellentesque ultrices mattis odio donec vitae nisi nam ultrices libero non mattis pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla sed vel enim sit amet nunc"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "HOMEOLAB USA INC.",
        Hours = "M-F: 1AM - 9PM",
        Services = "checkups, exams, operation",
        EligibilityRequirements = "Age, Insurance",
        Website = "http://godaddy.com/est/lacinia/nisi/venenatis/tristique/fusce/congue.js?volutpat=elementum&erat=eu&quisque=interdum&erat=eu&eros=tincidunt&viverra=in&eget=leo&congue=maecenas&eget=pulvinar&semper=lobortis&rutrum=est&nulla=phasellus&nunc=sit&purus=amet&phasellus=erat&in=nulla&felis=tempus&donec=vivamus&semper=in&sapien=felis&a=eu&libero=sapien&nam=cursus&dui=vestibulum&proin=proin&leo=eu&odio=mi&porttitor=nulla&id=ac&consequat=enim&in=in&consequat=tempor&ut=turpis&nulla=nec&sed=euismod&accumsan=scelerisque&felis=quam&ut=turpis&at=adipiscing&dolor=lorem&quis=vitae&odio=mattis&consequat=nibh&varius=ligula&integer=nec&ac=sem&leo=duis&pellentesque=aliquam&ultrices=convallis&mattis=nunc&odio=proin&donec=at&vitae=turpis&nisi=a&nam=pede&ultrices=posuere&libero=nonummy&non=integer&mattis=non&pulvinar=velit&nulla=donec&pede=diam&ullamcorper=neque&augue=vestibulum&a=eget&suscipit=vulputate&nulla=ut&elit=ultrices&ac=vel&nulla=augue&sed=vestibulum&vel=ante&enim=ipsum&sit=primis&amet=in&nunc=faucibus&viverra=orci&dapibus=luctus&nulla=et&suscipit=ultrices&ligula=posuere&in=cubilia&lacus=curae&curabitur=donec&at=pharetra&ipsum=magna&ac=vestibulum&tellus=aliquet&semper=ultrices&interdum=erat",
        Phone = "772-846-7084",
        Email = "eferrone2f@globo.com",
        Description = "tincidunt in leo maecenas pulvinar lobortis est phasellus sit amet erat nulla tempus vivamus in felis eu sapien cursus vestibulum proin eu mi nulla ac"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Physicians Total Care, Inc.",
        Hours = "M-F: 8AM - 8PM",
        Services = "scans, operation, general medicine",
        EligibilityRequirements = "Insurance, Income",
        Website = "https://printfriendly.com/pellentesque/ultrices.xml?cras=vitae&non=quam&velit=suspendisse",
        Phone = "571-137-0620",
        Email = "zaspinwall2g@yandex.ru",
        Description = "nunc commodo placerat praesent blandit nam nulla integer pede justo lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Bryant Ranch Prepack",
        Hours = "M-F: 5AM - 3PM",
        Services = "general medicine, exams, checkups",
        EligibilityRequirements = "Location, Income",
        Website = "http://netlog.com/bibendum/felis/sed/interdum/venenatis.aspx?est=faucibus&donec=cursus&odio=urna&justo=ut&sollicitudin=tellus&ut=nulla&suscipit=ut&a=erat&feugiat=id&et=mauris&eros=vulputate&vestibulum=elementum&ac=nullam&est=varius&lacinia=nulla&nisi=facilisi&venenatis=cras&tristique=non&fusce=velit&congue=nec&diam=nisi&id=vulputate&ornare=nonummy",
        Phone = "626-293-2962",
        Email = "kswaite2h@yolasite.com",
        Description = "rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at nunc commodo placerat praesent"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Dr. Reddy's Laboratories Limited",
        Hours = "M-F: 3AM - 2PM",
        Services = "general medicine, scans, outpatient procedures",
        EligibilityRequirements = "Age, Income",
        Website = "http://tiny.cc/platea/dictumst/morbi.xml?nulla=felis&justo=eu&aliquam=sapien&quis=cursus&turpis=vestibulum&eget=proin&elit=eu&sodales=mi&scelerisque=nulla&mauris=ac&sit=enim&amet=in&eros=tempor&suspendisse=turpis&accumsan=nec&tortor=euismod&quis=scelerisque&turpis=quam&sed=turpis&ante=adipiscing&vivamus=lorem&tortor=vitae&duis=mattis&mattis=nibh&egestas=ligula&metus=nec&aenean=sem&fermentum=duis&donec=aliquam&ut=convallis&mauris=nunc&eget=proin&massa=at&tempor=turpis&convallis=a&nulla=pede&neque=posuere&libero=nonummy&convallis=integer&eget=non&eleifend=velit&luctus=donec&ultricies=diam&eu=neque&nibh=vestibulum&quisque=eget&id=vulputate&justo=ut&sit=ultrices&amet=vel&sapien=augue&dignissim=vestibulum&vestibulum=ante&vestibulum=ipsum&ante=primis&ipsum=in&primis=faucibus&in=orci&faucibus=luctus&orci=et&luctus=ultrices&et=posuere&ultrices=cubilia&posuere=curae&cubilia=donec&curae=pharetra&nulla=magna&dapibus=vestibulum&dolor=aliquet&vel=ultrices&est=erat&donec=tortor&odio=sollicitudin&justo=mi&sollicitudin=sit&ut=amet&suscipit=lobortis&a=sapien&feugiat=sapien&et=non&eros=mi&vestibulum=integer&ac=ac&est=neque&lacinia=duis&nisi=bibendum&venenatis=morbi&tristique=non&fusce=quam&congue=nec&diam=dui",
        Phone = "892-735-4194",
        Email = "ahead2i@seattletimes.com",
        Description = "non mi integer ac neque duis bibendum morbi non quam nec dui luctus rutrum nulla tellus in sagittis dui vel nisl duis ac nibh fusce lacus purus aliquet at feugiat non pretium quis lectus suspendisse potenti in eleifend quam a"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Teva Pharmaceuticals USA Inc",
        Hours = "M-F: 6AM - 9PM",
        Services = "exams, general medicine, checkups",
        EligibilityRequirements = "Location, Age",
        Website = "http://cargocollective.com/volutpat/in/congue/etiam/justo/etiam/pretium.jpg?sit=duis&amet=bibendum&sapien=morbi&dignissim=non&vestibulum=quam&vestibulum=nec&ante=dui&ipsum=luctus&primis=rutrum&in=nulla&faucibus=tellus&orci=in&luctus=sagittis&et=dui&ultrices=vel&posuere=nisl&cubilia=duis&curae=ac&nulla=nibh&dapibus=fusce&dolor=lacus&vel=purus&est=aliquet&donec=at&odio=feugiat&justo=non&sollicitudin=pretium&ut=quis&suscipit=lectus&a=suspendisse&feugiat=potenti&et=in&eros=eleifend&vestibulum=quam&ac=a&est=odio&lacinia=in&nisi=hac&venenatis=habitasse&tristique=platea&fusce=dictumst&congue=maecenas&diam=ut&id=massa&ornare=quis&imperdiet=augue&sapien=luctus&urna=tincidunt&pretium=nulla&nisl=mollis&ut=molestie&volutpat=lorem&sapien=quisque&arcu=ut&sed=erat&augue=curabitur&aliquam=gravida",
        Phone = "360-121-5132",
        Email = "jjanew2j@vk.com",
        Description = "lorem quisque ut erat curabitur gravida nisi at nibh in hac habitasse platea dictumst aliquam augue quam sollicitudin vitae consectetuer eget rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at nunc commodo placerat"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "A&Z Pharmaceutical, Inc.",
        Hours = "M-F: 5AM - 8PM",
        Services = "operation, general medicine, outpatient procedures",
        EligibilityRequirements = "Age, Insurance",
        Website = "https://multiply.com/id/ornare/imperdiet.xml?in=ligula&faucibus=vehicula&orci=consequat&luctus=morbi&et=a&ultrices=ipsum&posuere=integer&cubilia=a&curae=nibh&duis=in&faucibus=quis&accumsan=justo&odio=maecenas&curabitur=rhoncus&convallis=aliquam&duis=lacus&consequat=morbi&dui=quis&nec=tortor&nisi=id&volutpat=nulla&eleifend=ultrices&donec=aliquet",
        Phone = "547-459-4785",
        Email = "apettingall2k@163.com",
        Description = "eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "A-S Medication Solutions LLC",
        Hours = "M-F: 3AM - 6PM",
        Services = "general medicine, exams, scans",
        EligibilityRequirements = "Age, Income",
        Website = "https://cnbc.com/libero/nullam/sit/amet.json?odio=sem&in=mauris&hac=laoreet&habitasse=ut&platea=rhoncus&dictumst=aliquet&maecenas=pulvinar&ut=sed&massa=nisl&quis=nunc&augue=rhoncus&luctus=dui&tincidunt=vel&nulla=sem&mollis=sed&molestie=sagittis&lorem=nam&quisque=congue&ut=risus&erat=semper&curabitur=porta&gravida=volutpat&nisi=quam&at=pede&nibh=lobortis&in=ligula&hac=sit&habitasse=amet&platea=eleifend&dictumst=pede&aliquam=libero&augue=quis&quam=orci&sollicitudin=nullam&vitae=molestie&consectetuer=nibh&eget=in&rutrum=lectus&at=pellentesque&lorem=at&integer=nulla&tincidunt=suspendisse&ante=potenti&vel=cras&ipsum=in&praesent=purus&blandit=eu&lacinia=magna&erat=vulputate&vestibulum=luctus&sed=cum&magna=sociis&at=natoque&nunc=penatibus&commodo=et&placerat=magnis&praesent=dis&blandit=parturient&nam=montes&nulla=nascetur&integer=ridiculus&pede=mus&justo=vivamus&lacinia=vestibulum&eget=sagittis&tincidunt=sapien&eget=cum&tempus=sociis&vel=natoque&pede=penatibus&morbi=et&porttitor=magnis&lorem=dis&id=parturient&ligula=montes&suspendisse=nascetur&ornare=ridiculus&consequat=mus&lectus=etiam&in=vel&est=augue&risus=vestibulum&auctor=rutrum&sed=rutrum&tristique=neque",
        Phone = "408-727-2466",
        Email = "msurby2l@businessweek.com",
        Description = "aliquam convallis nunc proin at turpis a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut ultrices vel augue vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere"
,
        Type = "Provider"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Lornamead",
        Hours = "M-F: 1AM - 5PM",
        Services = "general medicine, outpatient procedures, operation",
        EligibilityRequirements = "Insurance, Income",
        Website = "https://usda.gov/justo/maecenas/rhoncus/aliquam/lacus.jpg?at=at&dolor=lorem&quis=integer&odio=tincidunt&consequat=ante&varius=vel&integer=ipsum&ac=praesent&leo=blandit&pellentesque=lacinia&ultrices=erat&mattis=vestibulum&odio=sed&donec=magna&vitae=at&nisi=nunc&nam=commodo&ultrices=placerat&libero=praesent",
        Phone = "231-958-1553",
        Email = "qandrioni2m@cocolog-nifty.com",
        Description = "lacinia sapien quis libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "KAISER FOUNDATION HOSPITALS",
        Hours = "M-F: 5AM - 1PM",
        Services = "checkups, outpatient procedures, Support",
        EligibilityRequirements = "Income, Insurance",
        Website = "https://imdb.com/cubilia/curae/donec/pharetra/magna.js?at=metus&velit=aenean&vivamus=fermentum&vel=donec&nulla=ut&eget=mauris&eros=eget&elementum=massa&pellentesque=tempor&quisque=convallis&porta=nulla&volutpat=neque&erat=libero&quisque=convallis&erat=eget&eros=eleifend&viverra=luctus&eget=ultricies&congue=eu&eget=nibh&semper=quisque&rutrum=id&nulla=justo&nunc=sit&purus=amet&phasellus=sapien&in=dignissim&felis=vestibulum&donec=vestibulum&semper=ante&sapien=ipsum&a=primis&libero=in&nam=faucibus&dui=orci&proin=luctus&leo=et&odio=ultrices&porttitor=posuere&id=cubilia&consequat=curae&in=nulla",
        Phone = "136-719-6864",
        Email = "ptrussman2n@ning.com",
        Description = "potenti in eleifend quam a odio in hac habitasse platea dictumst maecenas ut massa quis augue luctus tincidunt nulla mollis molestie"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Supervalu Inc",
        Hours = "M-F: 7AM - 4PM",
        Services = "exams, outpatient procedures, checkups",
        EligibilityRequirements = "Insurance, Location",
        Website = "https://wsj.com/praesent/id/massa/id.aspx?condimentum=primis&neque=in&sapien=faucibus&placerat=orci&ante=luctus&nulla=et&justo=ultrices&aliquam=posuere&quis=cubilia&turpis=curae&eget=nulla&elit=dapibus&sodales=dolor&scelerisque=vel&mauris=est&sit=donec&amet=odio&eros=justo&suspendisse=sollicitudin&accumsan=ut&tortor=suscipit&quis=a&turpis=feugiat&sed=et&ante=eros&vivamus=vestibulum&tortor=ac&duis=est",
        Phone = "806-673-8307",
        Email = "bkopman2o@themeforest.net",
        Description = "ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices erat tortor sollicitudin mi sit amet lobortis sapien sapien non mi integer ac neque duis bibendum morbi non quam"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Creekwood Pharmaceutical, Inc.",
        Hours = "M-F: 9AM - 1PM",
        Services = "operation, outpatient procedures, general medicine",
        EligibilityRequirements = "Location, Insurance",
        Website = "https://cnet.com/vitae/consectetuer/eget.js?accumsan=aenean&felis=auctor&ut=gravida&at=sem&dolor=praesent&quis=id&odio=massa&consequat=id&varius=nisl&integer=venenatis&ac=lacinia&leo=aenean&pellentesque=sit&ultrices=amet&mattis=justo&odio=morbi&donec=ut&vitae=odio&nisi=cras&nam=mi&ultrices=pede&libero=malesuada&non=in&mattis=imperdiet&pulvinar=et&nulla=commodo&pede=vulputate&ullamcorper=justo&augue=in&a=blandit&suscipit=ultrices&nulla=enim&elit=lorem&ac=ipsum&nulla=dolor&sed=sit&vel=amet&enim=consectetuer&sit=adipiscing&amet=elit&nunc=proin&viverra=interdum&dapibus=mauris&nulla=non&suscipit=ligula&ligula=pellentesque&in=ultrices&lacus=phasellus&curabitur=id&at=sapien&ipsum=in&ac=sapien&tellus=iaculis&semper=congue&interdum=vivamus&mauris=metus&ullamcorper=arcu&purus=adipiscing&sit=molestie&amet=hendrerit&nulla=at&quisque=vulputate&arcu=vitae&libero=nisl&rutrum=aenean&ac=lectus&lobortis=pellentesque&vel=eget&dapibus=nunc&at=donec&diam=quis&nam=orci&tristique=eget&tortor=orci&eu=vehicula&pede=condimentum",
        Phone = "882-140-5878",
        Email = "pmccutheon2p@timesonline.co.uk",
        Description = "dis parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque aenean auctor gravida sem praesent id massa id nisl"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Teva Parenteral Medicines, Inc.",
        Hours = "M-F: 8AM - 6PM",
        Services = "scans, operation, checkups",
        EligibilityRequirements = "Location, Insurance",
        Website = "http://amazon.co.jp/ac/enim/in/tempor/turpis/nec.xml?sapien=egestas&in=metus&sapien=aenean&iaculis=fermentum&congue=donec&vivamus=ut&metus=mauris&arcu=eget&adipiscing=massa&molestie=tempor&hendrerit=convallis&at=nulla&vulputate=neque",
        Phone = "244-652-9804",
        Email = "sbriamo2q@army.mil",
        Description = "suspendisse potenti cras in purus eu magna vulputate luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus"
,
        Type = "Article"
      }); context.SearchResults.Add(new SearchResult
      {
        Id = Guid.NewGuid(),
        Title = "Actavis Pharma, Inc.",
        Hours = "M-F: 5AM - 1PM",
        Services = "Support, exams, operation",
        EligibilityRequirements = "Insurance, Location",
        Website = "http://pcworld.com/in.jsp?sit=sed&amet=accumsan&nulla=felis&quisque=ut",
        Phone = "546-675-9726",
        Email = "bhardware2r@addtoany.com",
        Description = "lectus in est risus auctor sed tristique in tempus sit amet sem fusce consequat nulla nisl nunc nisl duis bibendum felis sed"
,
        Type = "Article"
      });
    }

  }
}
