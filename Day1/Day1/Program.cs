﻿int PartOne(string inputs)
{ 
	var stringSeparators = new string[] { "\n" };
	var lines = inputs.Split(stringSeparators, StringSplitOptions.None);

	var sum = 0;

	foreach (var line in lines)
	{
		if (line.Equals(""))
		{
			continue;
		}
		var charArray = line.ToCharArray();
		
		var firstNumber = 0;
		var secondNumber = 0;
		var foundFirstNumber = false;
		
		foreach (var ch in charArray)
		{
			if (!foundFirstNumber && char.IsNumber(ch))
			{
				foundFirstNumber = true;
				firstNumber = int.Parse(ch.ToString());	
			}

			if (char.IsNumber(ch))
			{
				secondNumber = int.Parse(ch.ToString());	
			}
		}
		
		if (secondNumber == 0)
		{
			secondNumber = firstNumber;
		}
		
		var numberString = firstNumber + secondNumber.ToString();

		sum += int.Parse(numberString);
	}

	return sum;
}

int PartTwo(string input)
{
	var validDigitsDict = new Dictionary<string, string>
	{
		{"one", "1"},
		{"two", "2"},
		{"three", "3"},
		{"four", "4"},
		{"five", "5"},
		{"six", "6"},
		{"seven", "7"},
		{"eight", "8"},
		{"nine", "9"}
	};
	
	var stringSeparators = new [] { "\n" };
	var lines = input.Split(stringSeparators, StringSplitOptions.None);

	for(var i = 0; i < lines.Length; i++)
	{
		foreach (var digitAsString in validDigitsDict)
		{
			if (lines[i].Contains(digitAsString.Key))
			{
				var middleIndex = digitAsString.Key.Length / 2;
				var modifiedKey = digitAsString.Key.Substring(0, middleIndex) + digitAsString.Value + digitAsString.Key.Substring(middleIndex);
				
				lines[i] = lines[i].Replace(digitAsString.Key, modifiedKey);
			}
		}
	}
	
	return PartOne(string.Join("\n", lines));
}

const string testInputsPartOne = "1abc2\n" +
                            "pqr3stu8vwx\n" +
                            "a1b2c3d4e5f\n" +
                            "treb7uchet";

const string testInputsPartTwo = "two1nine\n" +
                                 "eightwothree\n" +
                                 "abcone2threexyz\n" +
                                 "xtwone3four\n" +
                                 "4nineeightseven2\n" +
                                 "zoneight234\n" +
                                 "7pqrstsixteen";

const string testInputsPartTwo2 = "eightwothree";

const string input = "dqfournine5four2jmlqcgv\n7ggzdnjxndfive\ntwofive4threenine\ndttwonezbgmcseven5seven\n5vsrcnine\n95zzbjck\ngkoneight4fivekvktltnine\nfiverckdmgbfthjdqpmpgdkmcklqtqc365mqtwo\n44sevenhvstcbgkhm5foureight11\ndprrtrngrfccz4eight4two8sthmfive\n6twofive4seven7nine\nfour1sevenbfbnqvkbfoursix7\n12xpdghpeightqvztrsslgsix5smlgfjhcpst\n8dhzdtbeightfour3\npttdtmhg4\n6eightsevendbtbxnqzxds6\ntwothree5nxglqlc9\nnine6lqhnvbpxoneseveneightsxjfkz4vr\nthree28jxdmlqfmc619eightwol\n26jtdpgqjzshncxvlljfour\nqxvpsctgx1\n28286qdjjlgtdtnsm3hk\n9hcj6nine\nnineseven9sqtrpfour\none1eight4sixzltzrkthree\nthreevlgfxhnf6seven6nine68\nsixonesxxbxvfnkt8\n8fivefivefour7sxsrvdrz\noneone7\nndtkjbsix6three9gdsjlljtj6six\ncfmrfgjqgrzcmsix5\n3threefour62three3vrmnmgx\nkckdghseventwo1758\nmdbqqjmpvonetwo1six31fourntbfb\nlkjhjdthree3\nqthseven61mpfnnhm6fivecnhz2\ntwojrfgzjstjvlngnpqcj8grtnvxmzbxkfrvqmvnmvmbdr\nsloneightkqbgcpnv8kqcmzfouronesevenmrfjeight\nxdxdxg9seventwo8xcq1\ndpdgxzk7\n18six3twoone\n1twoseven3five\n46tkbclbkleight64\ntjprpjbshr2seven1pgfqmbmjlvsv\n3mbjccssjgtdttvbdhdfxvldpmhcpc\nlgfrkpsfvz5ppgqphtwoznjtgxdjpm3\nmjmlsevenggsbjbtsix9nineone\njqfqjqhthreenine7eightklkttdkbtmpp1\ntrptrkbone52eight6\nonetmvsrjlbqlninesix8\nrone9ktvdqkdgl1\ntwosix5sixgrfdft54klf4\nthrmone3eightsixfive\nthree4one\nppthg2three1one\n7vt426\n22foureight6\nfourxbhmone56seven8eightnine\nvhmsd171rgkhpgfhffnhkvt\nxgbzxszsgtthree4\nrclzfsn5twoeight\n989nine2seven\neighteight5fivensix8\ndfxzz5qcqzsjsg\nd3eight54\n5knflhntzthreeseventwo\nthreeonefour9oneninebsfpq\nhjhgtjgtwotrsffive8hfntm\nsixpmhzqrlkrthreefour1pcgvz96\n5three31xqcsshkkqtfblffcmcntfour\nzghcfvjsfz29nine\n3vvvrlrjdztlhqqm88\n39nine3seven93\n1fqsgnjzrl6lrzsczc\nthreepldztlnvnzdntqllpr19\nninekgqqrgttfntrhjzlvninelr3\n94eighteighteight\ntwo13txmtlqxskhltkrvbjrzm97five\ndbmjvszjtb17\ntwogpfttmhp8two13\nfour4bqzqscdbctssgxfzjjntwonfcktjrtnxskjpkhvlfjt\nctxxvdsvsvjzchmxvxceightthreembnlg5ninevmcbgsvbh\nfpbrpfourqmrfcnpvxg8onehkbbgbsnnt\n4zrrgsevenfour\n6eight9foureightxlgdn\n693rzcnvlfrv\nbcftntcfl4jxbccpcmjeightcrxsjscmxdeightmhqbnpdvcfour\nsix83\nxl4\nnjslckcbdfvkmkdk9eight\nninenineeight4nine\njkzvq3fourzzvdzdft\nbfqpb9\neight6nlzdskjfourbmdvcrcgrshbjcxfour2\n7zhlxtqtbjxqbszdtwonineeightjcl9\nfvcjzxd5sevenfivefqnvkjthreeseven\n3cxmpzkng3\n8x2\nnineeightsevenfourpfzzflnp97\n2lkjpfhnpn7gbtztgxtnmclzdtdh33eightstbfrvxqz\nnv8\n3one7eight\nninetwortwoeightfive8ls\nshncxrjqnjttvvzvnl6\nninethree963\nmjcfrzjhr33csjxrtmm\nfive17\n84bdfnptmffourfbqslsqeight\nonegrzpdj8three2one6fsk\neight33gxpcqvpmeightk\n6fbsfclhninetqj5twobxcz\n119sixnjmxmvv\n825bhceightone4jjdbvrzt2\nxjchvkxxhg3sevensixseven3kmgqfmbgmbjnrq\nl2\n36hcmfnbmsevenfivetxhhgjdlq1khkk\neightj47five4sqtwo\n6nineeight9\ng2drvxqvpnbjfqxhl\nvglkfour9rlmhsnine\nonefivezr6rrtddnrg\n3threellcbhjhjzqfive5\nggbmhzkcone2\n23nclcqvjdzqcrpvsmnpzsfg3five\ntwo5eightddxqgpm8twoseven\nnrvtvlhrlr3tvpck1ghbvzxhjkneightgzxgtcddk\n7lsxfjhqz\n28four\nmninetwo3\n1fourfxqjpggbpb9threelj\nseven3pzkfbqdstdgkrskqrlbg7fzfour4n\nbtctmct9three6threegkqqkcskfs8chvmcl\nthreefourskdp6twob\n7three6five6eight3\n5spkb6\n34msnt\n5bkqbzpgmjzeight\n7g2onefour29fourfour\n9fgsixzkbscvbxdsfive6spjfhzxbzvgbvrthreeoneightn\nrpbd255fournine\n277five\neightseven7sevenllninefive\nrpjcmzkthbvdflbhxxkpv3oneplglgmv\nxqktwone5jkpxvnptjeight\n67one\ncgxfhzsnrsjp3kjgzrlbhzh\nfiveqqjljzfcmbfqvkscpzscpseven4nine1xvjlgk\ntflkxnml5vptclnhkgdg11c2seven\nsixeighttdbczshg82threepmjnxrvcnine6\nnineone81mkltdkfgxtsevenfive\n8zgx\ncvb4kv22gp\n61bjllhkblllqx8bmr5threesix\n9cjfgb1bxncrgfhtmg973\neightninefour5twosixbsvnsndhtghtmfive\nseven1bbfrvdcsthree2\ncfzd8hvqscjxqf9\nsixvfkcgmvqn9vmbzccdmqqgxmfxmnqc95\nqqrqnd8twofive7czxtjnmxx\nthreebdmrlnxnlmdbzbv4\nnm91vblgfourtsjp6\nsix96\nsevenrjvbxptl9onecrlz\ndvdbrmchgpninenine4onedjcfoneninetwo\nhcrrgnlxftwo6four\nthreehcrfknsnqmg49\n2tqbrkxgtdztjkdcnsix6three\nmktnzjn58qspzpqdr7\ndphvck5fourbmfnskkh72five78\none7seven7\nbmpnljsxhfmtwozrhvdv8sjsrmnzlcjvjqcfgffhkjcbx\n7one6874\nthree9tfx4\neight9pqhseightndgbv6\n39jgmbzrzkctsix\n1676\n8xtpdhzfd8three44four8two\nsixkvlppxqktkdqjsgjgz5\ntwoonehbgsdhpxkdvnpr3ncrgbqzfvsbcdsix4\n39kpdxsp368seven2\nxfljqfbz5tzpldspxvgc\nfourqb6twocfljflzqqd\n5889cxvxkstlld75rnlgzpgmhcmnx\n84zxqsqvb\nfiveksvtbqz9934\nonefour96four78fourkbkhdhg\nh61three2v\nnine9jlbrfmgjv2kkfive\nbjhktrjmfninexxnjhrvq7\nfbcxlvgkkjcmpdcz7\nmnleight3oneqqttlp\neighttwolffour1\nonetqfghfourbmf5\nfour1qfive4\n9fvp\ncxxn5qzcm\none7hzjpnvhtdq\npxmht4fprcftwofive7gsixcqbmrd\nthree9fivesixrdqrhcqrqbl\n6fggvr\nninesixmxvdcqgxcmskl115lskkp\nsevenqkmqxltfive191lfbtfvzsixseven\nninemjnjgrlmnlseven5eight9\nfhjjtxzksseven7fourthree\nrfjksvfour26vqbdrbxc\n6zgkfive8mhgxbsm\n1njpjv696\n4lrthsevendnsmseven\nl4hxvjvlfpjmdbvdjzrhkhpmklnine7fourfour\n2qtkhnineeightone\nfivexhrxrzxht1foursix\nsixlzcgllrqlhghzn1hdhgltcntfivefourfive1\ndpkzdbzsgq9threecst7znsjgdmmhx1\nthree497lp388\nllnklrkfr3\nltkkv481pzhqzkmhskxlznineninekcbrphlp\nfivetwoseven71nineljsbc49\nbvqsxnkpmzsevenhdpvfvlb2eight2bdxp3\nonefour64\n8xfdtfnqvhzkhvszeight5\nthreethree4two\nz5two2fp\nfourvjmcghrcfoureight3\nlhztwo9dzhpdgn675\njnine4two49sixskv\n9phbnnsoneqtpvvzbx5xzc\nmtjfxzzhzdjvfmrc1\n4ccszl3fiveseven55lfmktz\nfive27three9mgrnjcsbpd\n6eight115five4c\ntwo63fjlkgninepthmone\n22ddxpbbpdseven\nzg7\nfive3gvbthree6hjseven\nx6six58nine\nseveneighteight75three9two9\nonevlpdgsnl3\nsevenmbvqmjhfnzmgsqp8qnskjzptpppbcfhck2\n7bpldrqr6fourpsntqbcqhfive\ntwothvddvmlbqknrj9pgpsjndbrmrgkgf\nsixthree38onefoureightmvdtnn\nvkqcnfkkc6\nsixeight9\n65fouronemklfgqbpgnvlvcvhjcdkq\nthree5five\n981gxpsgqxjktwogninezgnf\ncfnnzfnlmfqtwofour8fourxg5\n45mpgbgzctwoqlsxmgs8\n5nhzlcb6four6pzjjlr4ninej\ngnkoneightprhlrseven7\n1rzsq1seven3eight\nsixnine9eight8eight\nlcszz858\npdgbgjxthreethree3threeonengk\n8zpzpttrqtwoninek895\n634jgvbvr\nnine8mvr\n5seven2psmtnmzdfivesix\n56ninerqrlzqvszrght6zkgtvrphpnvthree\n5fiveone\n43three\n9mdtghvfjdqqbrmeightfour92tlstxvrhthree\nb8\nninehpnmdhjqjl5ppptrd\n41fournineeightvxxjdthreeeight\nntwonefnsdpnine8sevenbjzxpfive\n6oneclxflmxvtwo1\n9jbpfnvfsjblmxrprml5\n68five7sfgxjqxrcjmninerzgxnhjpzkdhxzbg\n1vztdlnone2lhrhx\n6lrmdrxqlsttwovsr9eightpbmqcxn\n2zjchhdbzhc\ntsgntwomdtsjtdrthree9\n7threethreedprbrvngxpfour\nfivestvv3six\n6one9sjlzjtxxnkbckdmc\nzxqzmcz3eight\nlndh86xphvbnine\nfivesix3sixf93hbbptwo\n3cxpbl\ngsnqeight8kthxzrdkskjkmcmsknine5\n67twoxdqninefour\nfivefivehtczfmrhvlsevensevennbjkvhz84\ncmbgm3eightpbmgjhsp2\nfivepdhtcpvg3ninenlhpgdlnnine6fblsmlz\nkcnsfsfhjbcffctznvp1\nqzrkvhcds4gklftv\nxslgkktct7snbxnplbk3five\nzspb1sevennine76one\ntwonxtngxlrftltqggpftj3eight1gsrkbbclll\n474jxtncx\nbxsqsb8\nsvsvvtzddklkrxmpd2\nxbvjfmcnine2znbqn5eight2smvkgpclvs6\ntnlpfivem7\n7seveneight2dfiveonesix6\nfspcrlcthreej1seven4\n7nineeight3hzfour\n9fivethree\nfour5ggbseven\n5hsv\n1ppkkkhfzn\npkfzkpv9mtktjvrssdftslonebpmhf\n8fhfqmzseven\nsix89htmnpmqsixzvxl\n9mbkcbnmptpkhqvvzxftss7\n48five\neight8118four7qsjb\ncpghtgncpkkxtrvrsgl81eightcfzsjfq6\nninecsthl8onefgpmc\n3threehnrone5dzcfdtpf2hdlnrxnmnhjqqqn\n5ninesix54\nlnzhtwo9446onefivefour\n8two427bvcdkckdgz8\n6six35seven\nsix2fcpzhbn6fivekm34\nhttmgldjfqnnhktmnhj4dsmffzknbq674\n9nxrtsmqbcrgghqtx6kdnrfjq\nthhmbpjldslpthkfxcfive1zrjqtpvjs8\ncjtbcn7five9nlpgsoneone8\nseven6eightx176ffrvml8\neight9jntmr4sevenmzjb\nmxk51gt\nthree21foursevendbvm\nzqtdz1ninemmhkjfiveeight\n98xlpkzb\n34two5four2cvtcjfdh\njvndgrtjonethree6\nninefivefive1lfqjqmptxvthree\nkkxfqqkf49\n3sixseven3dzpvnvt51rnzljdprb\nhpzpdrnkthreekct1mqdvljhrls3\nsix6sjsljgvgzhrzqpsznh3fivejpxsvqccrc\ncpvlr7\ntdgthree8twofivexxrvct\n62sixmt9ninefour\nninesevenfourzfzl43qssqrkktpnzjv\n8mfztzthreeldnjgsfseven\n356\n6vrlthreer9sone6\nsixs8six5sevenvnkgbmxj2two\n8eightpglsknpxmsixjgqcftmvprjlcdsfks\n3dlkbc1\nfive5eight1\n7seven49\nggoneeightgcfnfkgbmlfourdls23\nseven6jdpxxkfone\nlfive715\n2ninefivej2sixeight\nttwonethreethreesixzbqz7\nzmbqqcd8ztp46567\nnineeight11\nzhgsixthreejffqhzdfvfxjpfmjqqkm36one\n5vgftjvqkxj6pnctdcrktwoneq\n9ptmkf8six\nlbjxvnfiverjppbtrhf6xbdnsltlnrqsgmx8q\n365pxj63gshpg\nvlq5zhgj4\n98hc13nnrzfzschg64\n2twopq76kpmjdjflkqzxlvjhr\nrnvmblqhq1\n8j273qfpfkz\ndsevenvvdmxhhcd1dkz\nlkqhrxkmp96fppvsdtwombkfour\n3one7dzpbhsrdf5\n159ckggpfzlgntfrddvfiveeightthree9eightwodnp\neightseventhreeseven1\nmrzpk8\nfmvxth2eight8hjmfkdxjh\n3threeone\nnine5sixsixnzlqhsc\nxtxbgtntwosixfour85\n3eighthz4twoqmlhrzsevenkcqhgrghrd\n12ldchpqzm\nzcfjz5sixmqqmfsv9six6\nsixlzcdtd3qlcjqzrtthnine\n1one6nine\n11xqblttcrdvgb7mdqkphrbdx\nxbcc4mtgf5\nsevenfourmthree1hgpnmvcvgshzvcsjdbqqgmt\nv5xmghdgbkvnine\n29mkpfz7\njptwo4lqlrh2onefive7jhcngr\nfour6twosixsthjqpgh2\npctrvkmc82four2958\n12eight3\n7jbqeightlbbnpsvvdfrqccb\npeightwo6sevenfoursixdmchsd1\n53dhphzvhnknt65ninefive\n86fivegpnhl\ntpcspvvncglcsqjzlqrfivejgfl8zspdltrd7\nmhpskcvhn3bkjlmqd\nonetwo4lxmsnddzfbxcdcscjxxrzsvvzg3nvtrpncvpmc\nfprqq1bpqxvjmblc17\nfour7ninenineksjcktcbtzsmrfr\n3nineccrnhtgg2knczqnnineoneqsgm\n4xnkljmg7lmfvrhxm96\nfive458eighteightxcgrnine\nklrzfbrpkmtptdscktmcsqg5xonesix\nvtmh1glhzlkmrlgfourpsbhtbrvdz57one\n9eight53threethreepgnc\nfourseven3fivefq57\n5sixsixthreegdsrhkhdlk3six\nv9xqhpzkfivebnjslbzh548\njssdslcxxv3sdhbqnine5sixeight2\nvr1\neightsoneqrrqfoursixzngsths9three\nltwoltrplmlkzz5sssjmzgcjsixfivejhms\n49one\n2sevenfivethlgxmxssnvlsfst4\n8slfnfsfk\nfourszbtpvvlvppsqbsprthreexgrlp3zt4\nseveneight8rhonectrmxrjvnnthreetxmfbvxtlt9\ntwofive6eight9\nzqxpxlzjm3hmzjzgoneeight1seventwo\n9xbmqqtkstflg6onem2tdfsfjnxdmmzlrcnpm\npgcxbqvvj6\nxfsix893\n7four1\n63five\ntr9chvmlhhv6\njxc2six452\n11zvz\noneqkhstmkhb11fourninezs37\n3mxf3slhhs\nsixgdnljsfkfnffp67789nvgc\nsxptjdmqfv1eightsevenfpxpdnrtnqkdxhnzdm\ngrdgt9ninedxnqhrts\n8sevenxcsl1\nfiveeighttwo5\nbgroneight2pgzdpnzgchkq1\n5twozc62foursixeight\nsix61\ncbxzoneeight1\nhntwonebmslklfkfgpngvffour5\n1262ninemdjsrdk\nroneightqnjseven2\nrmnpjzflcmqdrdseven3\nltwollzgvr1fiveeightjvv7\nkkc5fourfive89\ncqnnhjxp4dtt\njeightwo1fgtlfpsixtwo9pptcpmjjsixone\n832\n9eightkhlprvq7seven\nninegeightbfvnvvnpslspcmscvqcqb6\njgksh2lkss6onexznvfhq\nflqhlpkzjvq3qvvgvjscr6v9eight\nhrgeightwo8\n3fvpkbrhqchlbsxhlqfone3eightmhtxbrninerbkrsnxbjg\n871eightnineq5f2\n6jnonergcjfvkhfive\none47fxgvgmoneoneoneg\n5xktmbkqftrlvztctxnqprpnine\neight4tfvsbtmhtwol\nrbjdrmbcrs9chvcj7s\neight12bdzqtvnqeight27rpt\nfq713oneone6rgrnd\ncdt96\ndbfrd4rczmbgnmfrltdlpbseven7lqhfive\nfourdxxkqjfpjxbcthzhbl67eightzks19\n2four5ntghsdcsdrjpbrtrt3bzgbtfnknine\ntvmnjgcsixnine8zrc39five\n5kcbfkj61three9tsqpvzdd\nqsmseventhreeone4twosix\ntwosix2\njzsmxs9plpsixpqxffive\nsixthreeseven4flbct\nmpplmsrjvz9\n8ttgt9ninesevensevengnprjnvxpjz\n8gmpgvbfjcdsnkcth9bbnqsqhqqzeight42\nnk5b\nfour98six83five\n415rqgdfsix\nmqrkmbvtm668\n6453twoone\n9fiveeightseven4gsshznxbkb5\nseven3ninedgthree\njckgvtvrs3six3trrzfrxfnm8\n98fivexxdqpmv74fbthtqqfourvttxnck\nfivenineonefour46tccfkrsrpqnxhtm\ntwobdsqhnscrkbzt19\nllmccgn8\n6eightoneonen57\nmeightwo1cjqsm3sixlrr\n98842\ntwofnsvbsxkxrzghhrz29\ntzfjthreebkkljhninetwoone6zgpgsgxq\nfournkcgf85seventwo\n642\nfour1oneninejbstfcdgjkjtppskglj1\n4four9eight2tnphxvfour\nsixjhcnxkksxthreeseven1four1\nrb34pqtnnfive2sevenone\n33sevennlnhrkkbshonefnrqq72\n3sevenfourlmqzfdjrq\ntmttpfb4mghtcpnine\nnhlqlcxff8\nfiveone5gxg\nfivecrjmsgljxb1mqmffour8mgtdxsjsix\n1jdkvzfmbq\nndzqgk6\nthreeg7twofour2twossldnmthree\n5rsltvdtworrglclfpctml3\nnine6fourmcqbhbvlmzgnfqtbcs\n5eight92\nninefivefour3kbnmrdmxjg2\n73vprclhthzz8\nninettjnnkrsix9kvxjknzkmsxtvdn\nbgzfv59fhsvcjvlgmhhzph58\nthreeonefivecgjstcmp57\n9onefoursix\nsjqjvd4three91\n9ccdjqfivefourfive6mrnkjqf\n7lzdrzjheightthree6\n43\nnineb8sixqqsxrpn\nfgkj15eight6gggndbjxvthree\none3sevenlfjqmbmssgbzs8pzjptxgvq\n77fiveqpjpfdqteighttpfh\n2333twonezrr\n8p4cxnjvbjlh9ninesix6\nninefour95\n67twosevencktwopjcmcxr\n9four1threejbrdmtkzn\nninenjhstmmmj3four\n4lnqjqtwo3zxfznvp\nsixfivesrxnttwochrkdrr7\n4three1\ntfeightwo9two69five\noneseven3sixfournnpkhhx9\nmdl8kfpvthree\nfxcxgmq5three3ninehdc8\none9eightfiveonernhbcxjninethree\n9three3fcpgxksix\nnine346946one\nhzkpbmdzdmsfkrbxvs6pnmqsevenlnr\nkzsgmsix5\nkdjdvvdl2\n8lcpfkhdltwo\nxjzfbgrmvxprqpflpbk9cnpxdkgmvvjz8vbrjhxvthfsjkk\nonefive7\ntjqmxncdbmsjznine1zlr\n648bhzlqnlvrshdgzonefive\neight2sixtdzznchf1seventwo4\nsevenzcmpbfbzdvjlztpx62\n5961\n97192fivethree\nseven1mcxnqqzvpp5\n8qn1eightseven\nhcrrthreesevenlkvhfbj96twonine9\ntwo8four\nhpkttfdpgb16\n19oneseven2onerl\n347seventwo\neight4threempfbxbssrrkscnc4eight\n555qrppcplpgtworxgbgdjdhltwothree\nv9627\ntwoninenine72tkcbk\none5jhczrlqmhr\nqnhr4xlckprn9x3bzrdbfrdql9\nlgtdv99kmgjjkzfive\nlrclbljqqpninerrjptvpfour2\nfiveltkcgdvgkeight7seven\ntwongdsevenfivefive3foureightwonn\n8svdmkflj\nrlbf4sevennc4jxsskjgktwodsxgtlkthree\nseven4nine4fivezjfsjghbcninefk\ndrghcjthreevstpdfth6sgqtx\nzkfthreefptvnvb9five\ngjcqspnkztlqdnzl6\n6nineqzgvhcnhjxbmtkcfm8one5five5\nthreesevenseventwoqrcvpvvrdljfone3\nv44nlcdx8eight\neightseven3bmfzeightzccxqk6ftlsmfp\nseventhreeseven3\n7eightgvxcdxzplrthreelqgbhvpqffivefour5\n8coneckchx5pfive\nxhbbmsvjnonethree4\nlnktfknbqfive4seven\n8prvncdq97hjjltzreight\n2dfktgjgdrvfour\n9onesixone\n873lsmllvsvp\n61dcjgpjvqxj\nxtwosixfiveseven2two\np4\nthreescgqlmkt43one\nplffdq4pcqfoureight9one\n357qzoneztwo6\n6ztllqsixgtfgcr\n4nineoneighthch\nfivesevenninesevenvpnfkjpeightjsvtqxgrx35\n8nsbjtjrhnv36\n4eightseven\n5rksnms6fgcnrttgl27four9l\n3gknvvffflfgdg\n8ts98n32one\n4vmvthreefourmttwo\nsevenskfmmmsjone95\nseven4fmnxskg2516four\nseveneightzjdnjthreethreefourpj3three\ntwo8one44three3\nbffeightwo3twosxljzljbllrtttzsevenxfonetwofive\n5eight5sevenfour\n4fkxqm\n7nine4seven\n6eight3sevenfive6pxjlschvhm\n5nine7spbqddhrqcbzrvhkrt88\ncnpbkmbfour88\n41twoeightlgcjfvms\nhktvctnine6mzccvthreefournine\n1dr66mg5one\nfive74\nbsrrldft858six2oneightm\nmmsvhxsm68seven\nlnjcnn4fiveninerlsqkcn3\nfgzjrlmfjktwofournine5782three\n1two8fiveninegndtnzndf41one\nkstskp4one9ponejlcqdvgkkdfive\nfour7two\nmzcbhhxgkfourfour34\nqvhnpbmvdbgxbnhcgthreesq7dvmdnhl9\n1jhmkdmmmjg\n6xzpvzvqbrnine8gg1771\nsixone9qvfft\n6eight152two6sdbl\nsevenjlpmzv7\njntrfc5\nztspfjhk4\n9fournlslrmlr3\n2kqsxx5\n3nineshlmjsevenfiveonellrtr\n7hcxxjkbsvknbmtwotninesrpsszktzjlntwo\nfv1six81\nonetwo4eightsixjkgmtvxptnxltqtptncfsix\neightzvmmone3eight9dglsqq5\njvqs4sevendl\n551six3oneseveneight\n5jtcbrmtbjmrb4sevensmmrctntvz7five\n9lrnfive4\ntwoxfltgdg5six\none4threeeight3eight4stlp\n2rpxk95sixslsc895\nseven15\n1sixsix9sevenkhlnhqtzptwovzrmbr\ntwo55six\ntwofour3\neight6fiveeightbmrr1sevenk3\n4flbntjtfivepzkjplzxn7\nljnpmnskjsixthreehpqdkccffg4sixfszddbz\n9gfsqhmonelgvxpkmnhldmthree7\n5vthvsrcbxbcrgqnine\nsix6nine2v\nhtnvsfmz7dtvthree6sevenfourfourrmsdfhkd\npb24\nsbmmdnfvmlfourfivenvcnb3jrctctmrhm\n2fourone52hkjvd4\n1bhpbmxhtr4eightwolkd\n5qrqbxtgppvvcms\nmgcgxpmj4dl3zfckcskbqnsknlctwonxsddvhl\n6zfv66onetwosixtwoxdx\n676jmzcdbcjnfrlrgqzfkmdxz\noneqhgcqjmjq4\nthree6qvlkksf98\nfivesix614s83\nthreeone9kplvzq28threegcmtrzzlsix\n5lxcjrvbthreednttcxfnfiveseven\nthreeeight5seven5jlhhfour2\nxcppxkxqffc6six\nfouroneseven1xrdtbvdsix\nvfqzhvzclbpj2\n5seven8xlhfivetwofivedvlbtvzvs\n7bjlrvnncgsseven7six\n3qsnhs\n2fivefour5\ngjgzjs1s\nvxhlxvgj39\nthree1lvnrfrbzj6nine\noneftpcjskxzhv21one2twomshxlh\nnine36\nninetwojfqbjkbtrfseven4nkszvtjnffeightwoxdd\neight1eightfiveonerzr4\nsevengtwokzcxvvg4\nqxkmfdznfive98eightfourprmsixthree\n1two743six\n274sixqqq62j\nsixfour4fourstxrskpxc1eight7\n2fourrzngcnlm112twoone8\nnnqfmonerrpxeightfive9\nklzrfbxjnznzkt24pjngplcdlftjz\n66gbsllhhgxn38\nthreelzzrxspvq8four\nqtvtpqspqflonetfrzvkthreeone8gsjqzgnv\n9vhlxrqtdmzrpfqh74zsgnmsdlqgcp2\nqkkkhxbrk35eightjpnmb761one\n4vp4four49two\nfive6nrmvcfzlt665\nskkqlzl1mrkgncmqnine68xvhfcsc\ntwo17kbjcdsstlxst6\nfoureight3twonglgrv\n6nine5\npgcmqzcfninepbgcrbzseven5zplhhbrjbpxj\nsevensix6fourtwonpninebt\neight7951one\nglvndtgdfkzzcbsmt36sevenfour3eight5\ndtvgrkkzvhflhcsknhsccmxzgfivetcpz4zrcl9one\njpg3onenineqzjseven8phltdpjrsr8\n68one\ngctzfjksevenszfblxone2seven6pd\n93nine42\ntwo19four97crzhqndbqpmpvj\n3six4mrntvlzntmqgcmms\n1gmpdqpfkkz\nxmsv3eightmdnqkdtzn814\n395zqfqrgzs\n9eight81cpnvrkkl\n7rddzbqfm5fouronekxkhlgf1\nfkclxddmxrpqzhqeight697\n2mtvxtgq5six\n3one9qvnpnmhzj6\nrvvf3six9fourrq\nr2eight55gvgpfs\ndtztwofivefive12\nthree6zfqhnjzvr2twosevenoneightqp\nsgleightwo2974c24\npplpgxnvzfpv4xlfive11four\n58one\n61four29\neightgxcgbrzd8five8\njxdzbxcc1one6pfivesixfiveg\ntwo542cvjxvmhhthreexkl\nthree8nhzz4\nsevenseven1seven14pxtwothree\nmpdcbdjkp8ninethree\nfourthreeg9pnine\nonesixfourtckbkjdkqbfjkgpk54\nqxh1twoclvzvsvgk2dvpkncltdt\nfivefourhjckmndtdp98jzgqvrhbhxeighttdxkjltrdq\n296dvxdxhdb4qbnmkzxh\ndjsrgct28vjkvsttnlf4\n7rhdkfvqbxninegnkbgcqv1four42\nseveneightdcb7sevenpdvqlmkvfive\n39lr83hhhrfivexbhr\nzx32sixeight\n7hsxxzjjdh4rc55threeseven\n5oneseven2sevenfourtwothree\n9oneqc3seventwofive5\nfive2hnfkvsxmhjfivefivesix\n3sixnine59three6mncxxxhkgxzlxscdzplm\neight9three62sixfour\n26hfc4four1\njrnxgrvrctbg3nine\nfour73dqfiveeighttwosevenknq\n94nine8fivevnvlnf\ntwopg79nine6kkpfgmpdlqhfc5\n511twogghonefour\nbvdneightsevenfcjnhccrlb7nine\nlpfoneightfrnsrpgkzsixv8\n1sevenseven981\n53kvftth53fourc\nzcmkkshveighteight1\n9sixcrfzhfxzzrrdtkscp\n8fhslkqzsc5jlpthreeninemjftx\nrsfourfkglt1hfvhgeightfourvbmsnine\nsixninefive5\n2jqdfddkzzqxnkv8two\nsevensevenmxhpqvmngfivecnhvg18\nthreesxrninenine31sixnmnssk\nkzvvsvbjrfoursix6four\nckvmxptpxrvpsfvt9nine\n66ninezgxttq1nineninexggjrtzgg7\ntwo2eighthsrnine5pmptccfkfcpcmkn\nseventqsqhbftscfonekdhrctnlcfdgzhvshsjgsbq7\nnine1mdpxvlxkdx\npm4eighttwo\n81ggljdxsthreeninefive\ntwofivenine39three\nsix152sixp\nthreemztwotwo5fiveseven\n31twoninefsxmpsjx6eight\nseven2deightone5threethree\nhxmthvjphjdgctfpt4dfhxseven\n4twoeightzx8\n9dzbjqnnmbseven7\ncrdtprqs455onedmzvkzmmm\njqcxsxblgml1\n9sbqzndbsx3twoseven7\neight8threezvvqbrsix34\nztzlrsg4qghxkvspvcsix2jndhxzfrm\n6twovjkjgptwo43lg\n1psnbrkbhb8seven\nxfxqjrggpmtf4fivenine79\n6pdv1xpsgr\nzb4rqrqxsevenvklzmslqls\nfourlstone7\n53joneeight8ninef\n1315\n1qj4\ndjeightwocxrnf5fourone4eightbqj\njrgxvsmnzg5\ntwonsjbzvtqhgfivejdhxstbzrbtpndnjlvb7hhxfmrxtfxrcmjs\n67xbctwo\n7nbsrhcvrqj\nfqnl9foursixtdgbcncr85three9\ngmg4mr3rvdt\n19qhmhvpzfour\npkptr6lssnqxncztpbt8\nsjqtxbxp5twoseven1onerrsqghcfpncgkfour\n7four8spgzfoureightthreedqp\ntwo9bxlqs\ndeightwoninethree8\n3plpprmmhvvsnvdzjzr9sqgbddpghthreejjmldhdqqm\nsevenfiveseven4bkvxkzqbtxjvdsltfkn\nsevenssfkdmvmntpxjpqlj8px\n4hk9\nfivenxcmhf78pmdd6mmqfvdxqbh7\nfive9hvfive7\neightfourrpflnfourtwo61\nthreenine2\nncdpjqcnine1twoonehglvzpzf\njmtpbhbshrvmhvqt38brsqpxn4one6\nonesixvmmhsevenfoureight2six\nttwosix5nineb3eightthree\ncmkdmhkdf3zdhjfmb\nthree5fiveqrrxrdtsixtwogntmvxsggqfive\noneeight5eightfive38twonegv\ncqlfhlch924mpmqfvtwo\njrnzg5four3fivetwokxphktf\nseveneightmzmzftx9gsmxjkj1stjbvxlvmlcdgnine\ntwonineeightninethree6blhm\n3kskponetfgjgzphqtr\nntwo2\n5six1vksjzrlgjnxtwovbkrdlhjsmzdxcf\ntwosixkfmcfndlj453two\nsix5twotzbzqtwo\nfivenpcqfour5twonej\nnineninefouroneztvqspscnk4twoklbht\nbqcbm19hckcgtcfkb44eighttwo\n52jcrbqbkhjx5nine8\n5threethree\n3twotrnnlstrndthree9\n15zsnrfshn7twoeightsmvsfztx\n789ckpxflvkr\nskxlnpxxdgbhqnineninejsltrx8three\n1sixone724\n2seven4\n7knspxrzszdbgc3seven\nvsqmpf5sixsix9eightdtgmpxrksb\nthree6btwo11fived\nbckqdndnine7bpzvkxkdqtwoseventxpzqg2\none6ntmlmfkfmjfourmgddpzfr5scjhhmgsix\nfour12mlhdscsxfiveonesevenlone\n9rdlctlkc\n11vjvjsllfivenv\n2four6fourfive\n5czmqmdkkthree3\nsevenfive9\nsevenfivemqjhqh9mvdkgtr\nglvpdbbhxs9\nfour2three\nsix6gtdbttnhvkvh\n5fcsbnpsixeightonetwo3\n5psvznthreethreefive5qrkftfkqsix\n36lmm\nseven33onefournlr2\n13seven\nonejdxgxjpcsix1sevenpzbzthree\nsevenqcjsxz6twokkpzllzqninetwo\n1367mtsldgrdeightp\nfive111hbp9tlqp\nthreebbnine7onesix2twoneg\nmxmpnxmpqponeeightktxvgkcdr7\n411fourdhrdvrz\nzxkmcr5eightkzqsixsix7\nsix972zleighttwonvgvth\nvnmmbzfpttwofnjd76\ntwopnthreeqzlvkptmph9vnkbxghnone66\nnine1fiveninethree4\nmdrdpbsfcjsixpnxfour2four2\nsgjrdtmzcj2mbnlbtqsdboneeight\n9jbmhchfrnfqvxcjtwokrbjvzmcxrj\n4jhjksqvnqsevennfrtslcgjbrhfour\n6eightlzrrxfbcjeight5six1kzhtpbz\njqsmqbzpntxdfvdthreezrqzdhthreefmvslxk6\neight82two82zqghmbd\nqtwone4d\n6three16\n9eightdmtkznh6\nznc1185\neighteight665bxbngx5dvht2\n9seven83three\nmqdnhqfdgzfshjttvfour3hq92qtpdblnvdsxcskz\ntwofourfivedfffknb6ljxjlsq48\n6pbdfrqpfour\nvmtkqpjftc9twonej\nrhcstmvxdnjgldpmlmsnineglmkntfiveeight3lgnlqmjkzl\nrxzbjxjhkvhtxps2twohlcdgkrbdbmxvpf4five\n1three9two\nbp234jszvspdq\nrcmhnmb3lpxneightfivetn7\nsrdh461fourcrhhkbxftghxqrptn\nrlhlrm894\njtmmljgmmppknktqrbjtwod9\n75kvnbm\npsbcdponesix218\nndx5zthreetwokjjvzkjk\nonerhnmsxmseven7two2snn34\nnvmfj6hqdspmndlzqhrrznrpcgn\nlqqgdmn5fivesfbqhveight1\none5pjpskd25four3\n91dxxjkrthreethreefourfiverrdhqtwo\n3sevenhbrznfcqmfivepqnmzxvlldhfdrvkqfmxzx8\nlrfflx9pvrfctxkxk432\nninerhjlqfzg3fourbvfkbmxbntz1\n6dkgtthreebjfgjqnv6lveight\nseven527rgztslznxdkgrgf6one\nnpchxbnb5zpzrllhx777\nrfour4qkvcxsbjnveightwogm\nfoursixsevenppnrdgpnrkbr5\n3three4lm\n1dmxvfour7\nfiveh1eight\n643\nfivelsffmhsldlfkqkb2threek6three\n23dpbpjcsqslnine4799\nshvkdvntpmvt52dvclb5bjdj\neight5sevenfbjrpbdsdzhnc\ndv2vqtqghlkprxx6three\nfour1six4fnznbcdghfzpd\neightfiveone4fourone\ntwo75four85\n3331\n9eight1seven\n9threexbsevenfour\n22meight1\n75two\nfive6onetwordjsgltj\noneseven9one\ndjljfzv7cnpnvhmqkjgn5eightsix97\nthree8xpskzk\nnzgpp7fdcl6twotwochsgztwo\n1tfvvmzfd4threekgqdthreesfxjggmszz\n7krlgg8864gfp94\n3xxpkqxfxcn\neighthl4cctb26bppqpsc\neight5rq\nhncmdrmfive4\nqml6mmx\nqpckxnrjbdlprhmrqeight3bcjtghrrfvczqxeight\nnine6five\nfourmnzrtwocvdkmlc6\n3sixseven1mnbdqfgcqqcpsix\nninekvxrhk2jjjrdlqf49\n7seven743\nxnrz1m5\ncseven8pg2\nhxbfzndh6nltvbv\n7zxdkghnzrzljlqftwo7hfmptrgd\n5jltxrmxn\n9eightqskgfndxsgmsrprhsvnninellts\ndz88\n99nine\nrphppqzzxk2four\n2nzeight\nfour44two\nqtwonetwodgbhqmtzf82onefive48\n6fivedhmv\nxsvpdrtvr28ltsjseven\nfoursixfour61nrseven\nqrhtwone3tmtsixf\nsqjvg2pzbzpgthreenine6cpsq\njlvnsbshjmxnxfouronesix2zlff5\nrzxkpczkn1bkcfbpbcb\n9nmkljlqmd9fivenine7fivexndtdghpc\n6twovgpsevenmzcbjtnd3threegmsltfhrgq\nfourmktnjsk4839ljqvqf\n47hcbcnhjgxhdfn7rrbonehvlmddbone\n26fchgtdnbtwo8jpqxkb\n7dxtslxqkbqfivefive\nsixnineqnjmseventwo5gh2c\nthree1eightvxeightwogrd\ntwotwoninesixxdvrxv5\nsixonetqddfmone1seven7\nfourseven9ninefoursxnnnfcbtb88\ntwonpbnblrh3qckkxckflprdnr4\n6eighttwo2sevenqml\nthree1twotwon1cjfnnnlptc\ntlqtgktgjtgfour24four91\nghseven56sevensixhfstvk\nqd8fourvmvgmssixsix8oneightps\njjvhthplcgzdndmrnxmctrtnndmzztnggr9rspflsix\njqk39fivetwo\nnine2sixrtwothree\ngccjpxtcxfone6six6nine5\n7twoeight8flzqk77\nmjljctdbg8\nsixthree8\nbbdlvtsjhjst88\ndklhhhlpqqxlgdzzheightjntbmlfour4\nggrbl5cthnzlsbjssixpt";

//Console.WriteLine(PartOne(testInputsPartOne));
Console.WriteLine(PartTwo(input));