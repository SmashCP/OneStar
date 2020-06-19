﻿using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneStar
{
	class AdditionalNestIdTable
	{
		public class Data 
		{
			public string IdNormal { get; }
			public string IdRare { get; }
			public int MapIndex { get; }
			public int PosX { get; }
			public int PosY { get; }

			public Data(string idNormal, string idRare, int mapIndex, int posX, int posY)
			{
				IdNormal = idNormal;
				IdRare = idRare;
				MapIndex = mapIndex;
				PosX = posX;
				PosY = posY;
			}
		}
		public static readonly Dictionary<int, Data> c_DLC1Table = new Dictionary<int, Data>
		{
			// 一礼野原
			{ 100, new Data( "6589539950519384197", "3561902408726248099", 0, 0, 0)},
			{ 101, new Data( "13563999851587423716", "502513031628180988", 0, 0, 0)},
			{ 102, new Data( "4780541378243794326", "18345017229883237822", 0, 0, 0)},
			{ 103, new Data( "2997411918588892139", "12562706121429926817", 0, 0, 0)},
			{ 104, new Data( "16341001078884806474", "9913932150092391706", 0, 0, 0)},
			{ 105, new Data( "7956530560371257544", "2024757571205803752", 0, 0, 0)},
			{ 106, new Data( "7854659797556875545", "5999950843982638879", 0, 0, 0)},
			{ 107, new Data( "4780539179220537904", "18345015030859981400", 0, 0, 0)},
			{ 108, new Data( "8769170721942624824", "14477537978666912344", 0, 0, 0)},
			{ 109, new Data( "2447364886159768926", "15632276665898509590", 0, 0, 0)},
			// 清涼湿原
			{ 110, new Data( "13305292637317525948", "16069264858016261892", 0, 0, 0)},
			{ 111, new Data( "2447363786648140715", "15632275566386881379", 0, 0, 0)},
			{ 112, new Data( "14284833672245134656", "7704513452465554544", 0, 0, 0)},
			{ 113, new Data( "16341001078884806474", "9913932150092391706", 0, 0, 0)},
			{ 114, new Data( "4780541378243794326", "18345017229883237822", 0, 0, 0)},
			{ 115, new Data( "6672704941776910536", "17951961757311600360", 0, 0, 0)},
			{ 116, new Data( "4780540278732166115", "18345016130371609611", 0, 0, 0)},
			{ 117, new Data( "2997411918588892139", "12562706121429926817", 0, 0, 0)},
			{ 118, new Data( "2447364886159768926", "15632276665898509590", 0, 0, 0)},
			// ファイトケイブ
			{ 119, new Data( "5830741396702654597", "17953607996949684899", 0, 0, 0)},
			// チャレンジロード
			{ 120, new Data( "14284833672245134656", "7704513452465554544", 0, 0, 0)},
			{ 121, new Data( "11635283243122928556", "17629394089387610164", 0, 0, 0)},
			{ 122, new Data( "6162140483756004486", "6162171270081594394", 0, 0, 0)}, // ルガルガン
			{ 123, new Data( "13563999851587423716", "502513031628180988", 0, 0, 0)},
			// 集中の森
			{ 124, new Data( "6672704941776910536", "17951961757311600360", 0, 0, 0)},
			{ 125, new Data( "16341001078884806474", "9913932150092391706", 0, 0, 0)},
			{ 126, new Data( "7956530560371257544", "2024757571205803752", 0, 0, 0)},
			{ 127, new Data( "7854659797556875545", "5999950843982638879", 0, 0, 0)},
			{ 128, new Data( "4780540278732166115", "18345016130371609611", 0, 0, 0)},
			{ 129, new Data( "15818376695778914966", "5701088864462885848", 0, 0, 0)}, // キョダイフシギバナ
			// 鍛錬平原
			{ 130, new Data( "8769170721942624824", "14477537978666912344", 0, 0, 0)},
			{ 131, new Data( "2997411918588892139", "12562706121429926817", 0, 0, 0)},
			{ 132, new Data( "2447363786648140715", "15632275566386881379", 0, 0, 0)},
			{ 133, new Data( "15818376695778914966", "5701088864462885848", 0, 0, 0)}, // キョダイフシギバナ
			{ 134, new Data( "7854659797556875545", "5701093262509398692", 0, 0, 0)}, // キョダイイオルブ
			{ 135, new Data( "6672704941776910536", "17951961757311600360", 0, 0, 0)},
			{ 136, new Data( "13305292637317525948", "16069264858016261892", 0, 0, 0)},
			// 鍋底砂漠
			{ 137, new Data( "6984833918694526192", "5701096561044283325", 0, 0, 0)}, // キョダイサダイジャ
			{ 138, new Data( "6589539950519384197", "3561902408726248099", 0, 0, 0)},
			{ 139, new Data( "8769170721942624824", "14477537978666912344", 0, 0, 0)},
			// ハニカームの海
			{ 140, new Data( "4780546875801935381", "18345022727441378877", 0, 0, 0)},
			{ 141, new Data( "14284833672245134656", "7704513452465554544", 0, 0, 0)},
			{ 142, new Data( "7956530560371257544", "2024757571205803752", 0, 0, 0)},
			{ 143, new Data( "13563999851587423716", "502513031628180988", 0, 0, 0)},
			{ 144, new Data( "12738905581603037598", "4426791916416848726", 0, 0, 0)},
			// ハニカーム島
			{ 145, new Data( "16882931869395424672", "4515385547978135952", 0, 0, 0)},
			{ 146, new Data( "16882931869395424672", "4515385547978135952", 0, 0, 0)},
			{ 147, new Data( "16882931869395424672", "4515385547978135952", 0, 0, 0)},
			{ 148, new Data( "16882931869395424672", "4515385547978135952", 0, 0, 0)},
			{ 149, new Data( "16882931869395424672", "4515385547978135952", 0, 0, 0)},
			{ 150, new Data( "16882931869395424672", "4515385547978135952", 0, 0, 0)},
			// チャレンジビーチ
			{ 151, new Data( "4780539179220537904", "18345015030859981400", 0, 0, 0)},
			{ 152, new Data( "6589539950519384197", "3561902408726248099", 0, 0, 0)},
			{ 153, new Data( "4780540278732166115", "18345016130371609611", 0, 0, 0)},
			{ 154, new Data( "6984833918694526192", "14413583907274219616", 0, 0, 0)},
			{ 155, new Data( "342604449375897784", "8253110425161551320", 0, 0, 0)},
			{ 156, new Data( "7956530560371257544", "2024757571205803752", 0, 0, 0)},
			{ 157, new Data( "13305292637317525948", "16069264858016261892", 0, 0, 0)},
			{ 158, new Data( "13563999851587423716", "502513031628180988", 0, 0, 0)},
			// 離れ島海域
			{ 159, new Data( "4780539179220537904", "5701091063486142270", 0, 0, 0)}, // キョダイキングラー
			{ 160, new Data( "4780546875801935381", "18345022727441378877", 0, 0, 0)},
			{ 161, new Data( "2997411918588892139", "12562706121429926817", 0, 0, 0)},
			{ 162, new Data( "2447364886159768926", "15632276665898509590", 0, 0, 0)},
			{ 163, new Data( "16341001078884806474", "9913932150092391706", 0, 0, 0)},
			// 並ぶ島の海
			{ 164, new Data( "6672704941776910536", "17951961757311600360", 0, 0, 0)},
			{ 165, new Data( "7725829814153603264", "5701092162997770481", 0, 0, 0)}, // キョダイカメックス
			{ 166, new Data( "5830741396702654597", "17953607996949684899", 0, 0, 0)},
			{ 167, new Data( "13305292637317525948", "16069264858016261892", 0, 0, 0)},
			{ 168, new Data( "2447364886159768926", "15632276665898509590", 0, 0, 0)},
			{ 169, new Data( "11635283243122928556", "17629394089387610164", 0, 0, 0)},
			{ 170, new Data( "6984833918694526192", "14413583907274219616", 0, 0, 0)},
			{ 171, new Data( "4780546875801935381", "18345022727441378877", 0, 0, 0)},
			{ 172, new Data( "342604449375897784", "8253110425161551320", 0, 0, 0)},
			// 闘心の洞窟
			{ 173, new Data( "4780540278732166115", "5701094362021026903", 0, 0, 0)}, // キョダイカジリガメ
			{ 174, new Data( "5830741396702654597", "17953607996949684899", 0, 0, 0)},
			{ 175, new Data( "342604449375897784", "8253110425161551320", 0, 0, 0)},
			{ 176, new Data( "2447363786648140715", "15632275566386881379", 0, 0, 0)},
			{ 177, new Data( "6984833918694526192", "14413583907274219616", 0, 0, 0)},
			{ 178, new Data( "4780541378243794326", "18345017229883237822", 0, 0, 0)},
			// 円環の入り江
			{ 179, new Data( "12738905581603037598", "5701095461532655114", 0, 0, 0)}, // キョダイアップリュー
			{ 180, new Data( "11635283243122928556", "17629394089387610164", 0, 0, 0)},
			{ 181, new Data( "6589539950519384197", "3561902408726248099", 0, 0, 0)},
			{ 182, new Data( "4780539179220537904", "18345015030859981400", 0, 0, 0)},
			// ワークアウトの海
			{ 183, new Data( "7725829814153603264", "5701092162997770481", 0, 0, 0)}, // キョダイカメックス
			{ 184, new Data( "12738905581603037598", "4426791916416848726", 0, 0, 0)},
			{ 185, new Data( "11635283243122928556", "17629394089387610164", 0, 0, 0)},
			{ 186, new Data( "4780546875801935381", "18345022727441378877", 0, 0, 0)},
			{ 187, new Data( "7854659797556875545", "5999950843982638879", 0, 0, 0)},
			{ 188, new Data( "14284833672245134656", "7704513452465554544", 0, 0, 0)},
			{ 189, new Data( "4665094036540599430", "11519945754184084270", 0, 0, 0)}, // メタモン
		};
	}
}
