using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupu
{
    [Serializable]
    public class StockInfo
    {

        public string lastUpdateDate = "19700101";

        //==========================基本信息======================
        //股票代码
        public string label = "";
        public string 证券代码
        {
            set { this.label = value; }
            get { return this.label; }

        }
        //股票名称
        public string name = "";
        public string 证券名称
        {
            set { this.name = value; }
            get { return this.name; }

        }
        //所属版块
        public string block = "";
        public string 所属版块
        {
            set { this.block = value; }
            get { return this.block; }

        }

        //综合
        public string Final_zhpj = null;// 综合评级
        public string 综合评级
        {
            get { return this.Final_zhpj; }
        }

        public string Final_gzqj = null;// 估值区间
        public string 估值区间
        {
            get { return this.Final_gzqj; }
        }

        public string Final_zrsp = null;// 昨日收盘
        public string 昨日收盘
        {
            get { return this.Final_zrsp; }
        }

        public string Final_jzpg12 = null;// 12步价值评估
        public string 十二步价值评估
        {
            get { return this.Final_jzpg12; }
        }

        public string Final_hypj = null;// 行业评级
        public string 行业评级
        {
            get { return this.Final_hypj; }
        }

        public string Final_czzlpj = null;// 成长质量评级
        public string 成长质量评级
        {
            get { return this.Final_czzlpj; }
        }

        public string Final_ycpj = null;// 预测评级
        public string 预测评级
        {
            get { return this.Final_ycpj; }
        }

        public string Final_tzpj = null;// 投资评级
        public string 投资评级
        {
            get { return this.Final_tzpj; }
        }

        public string Final_tzjy = null;// 投资建议
        public string 投资建议
        {
            get { return this.Final_tzjy; }
        }

        public string Final_tzpf = null;// 投资评分
        public string 投资评分
        {
            get { return this.Final_tzpf; }
        }



        //价值评估
        public string Jz_Fxpg_fxjz = null;// VAR风险价值
        public string VAR风险价值
        {
            get { return this.Jz_Fxpg_fxjz; }
        }

        public string Jz_Fxpg_mybd = null;// 每月波动
        public string 每月波动
        {
            get { return this.Jz_Fxpg_mybd; }
        }

        public string Jz_Fxpg_jfc = null;// 均方差
        public string 均方差
        {
            get { return this.Jz_Fxpg_jfc; }
        }

        public string Jz_Fxpg_zdhl = null;// 最大获利(元)
        public string 最大获利
        {
            get { return this.Jz_Fxpg_zdhl; }
        }

        public string Jz_Fxpg_zdks = null;// 最大亏损(元)
        public string 最大亏损
        {
            get { return this.Jz_Fxpg_zdks; }
        }

        public string Jz_Fxpg_dgx = null;// 低估线
        public string 低估线
        {
            get { return this.Jz_Fxpg_dgx; }
        }

        public string Jz_Fxpg_jzx = null;// 价值线
        public string 价值线
        {
            get { return this.Jz_Fxpg_jzx; }
        }

        public string Jz_Fxpg_hlbdx = null;// 合理波动线
        public string 合理波动线
        {
            get { return this.Jz_Fxpg_hlbdx; }
        }



        //行业评估
        public string Hy_Dj_scxdld = null;// 市场相对力道
        public string 市场相对力道
        {
            get { return this.Hy_Dj_scxdld + " [" + this.Hy_Sj_scxdld + "]"; }
        }
        public string Hy_Sj_scxdld = null;//


        public string Hy_Dj_czx = null;// 成长性
        public string 成长性
        {
            get { return this.Hy_Dj_czx + " [" + this.Hy_Sj_czx + "]"; }
        }
        public string Hy_Sj_czx = null;// 



        public string Hy_Dj_jzd = null;// 集中度
        public string 集中度
        {
            get { return this.Hy_Dj_jzd + " [" + this.Hy_Sj_jzd + "]"; }
        }
        public string Hy_Sj_jzd = null;// 



        public string Hy_Dj_tjd = null;// 推荐度
        public string 推荐度
        {
            get { return this.Hy_Dj_tjd + " [" + this.Hy_Sj_tjd + "]"; }
        }
        public string Hy_Sj_tjd = null;// 

        public string Hy_Dj_zhxj = null;// 综合星级
        public string 综合星级
        {
            get { return this.Hy_Dj_zhxj + " [" + this.Hy_Sj_zhxj + "]"; }
        }
        public string Hy_Sj_zhxj = null;// 


        //基本信息
        public string Jbxx_zgb = null;// 总股本
        public string 总股本
        {
            get { return this.Jbxx_zgb; }
        }


        public string Jbxx_ltsz = null;// 流通市值
        public string 流通市值
        {
            get { return this.Jbxx_ltsz; }
        }

        public string Jbxx_fltg = null;// 非流通股
        public string 非流通股
        {
            get { return this.Jbxx_fltg; }
        }

        public string Jbxx_zsz = null;// 总市值
        public string 总市值
        {
            get { return this.Jbxx_zsz; }
        }

        public string Jbxx_gjg = null;// 国家股
        public string 国家股
        {
            get { return this.Jbxx_gjg; }
        }

        public string Jbxx_syl = null;// 市盈率
        public string 市盈率
        {
            get { return this.Jbxx_syl; }
        }

        public string Jbxx_frg = null;// 法人股
        public string 法人股
        {
            get { return this.Jbxx_frg; }
        }

        public string Jbxx_mggx = null;// 每股股息
        public string 每股股息
        {
            get { return this.Jbxx_mggx; }
        }

        public string Jbxx_ltg = null;// 流通股
        public string 流通股
        {
            get { return this.Jbxx_ltg; }
        }

        public string Jbxx_sjl = null;// 市净率
        public string 市净率
        {
            get { return this.Jbxx_sjl; }
        }


        //12步价值评估
        public string Jz12_Dj_hxjzl = null;// 核心竞争力
        public string 核心竞争力
        {
            get { return this.Hy_Dj_tjd + " [" + this.Hy_Sj_tjd + "]"; }
        }
        public string Jz12_Sj_hxjzl = null;// 

        public string Jz12_Dj_hydw = null;// 行业地位
        public string 行业地位
        {
            get { return this.Jz12_Dj_hydw + " [" + this.Jz12_Sj_hydw + "]"; }
        }
        public string Jz12_Sj_hydw = null;// 

        public string Jz12_Dj_czxfx = null;// 成长性分析
        public string 成长性分析
        {
            get { return this.Jz12_Dj_czxfx + " [" + this.Jz12_Sj_czxfx + "]"; }
        }
        public string Jz12_Sj_czxfx = null;// 

        public string Jz12_Dj_ylnlfx = null;// 盈利能力分析
        public string 盈利能力分析
        {
            get { return this.Jz12_Dj_ylnlfx + " [" + this.Jz12_Sj_ylnlfx + "]"; }
        }
        public string Jz12_Sj_ylnlfx = null;// 

        public string Jz12_Dj_gszl = null;// 公司治理
        public string 公司治理
        {
            get { return this.Jz12_Dj_gszl + " [" + this.Jz12_Sj_gszl + "]"; }
        }
        public string Jz12_Sj_gszl = null;// 

        public string Jz12_Dj_cwzk = null;// 财务状况
        public string 财务状况
        {
            get { return this.Jz12_Dj_cwzk + " [" + this.Jz12_Sj_cwzk + "]"; }
        }
        public string Jz12_Sj_cwzk = null;// 

        public string Jz12_Dj_gdzjz = null;// 股东增加值12
        public string 股东增加值12
        {
            get { return this.Jz12_Dj_gdzjz + " [" + this.Jz12_Sj_gdzjz + "]"; }
        }
        public string Jz12_Sj_gdzjz = null;// 

        public string Jz12_Dj_jgrtd = null;// 机构认同度
        public string 机构认同度
        {
            get { return this.Jz12_Dj_jgrtd + " [" + this.Jz12_Sj_jgrtd + "]"; }
        }
        public string Jz12_Sj_jgrtd = null;// 

        public string Jz12_Dj_scqd = null;// 市场强度
        public string 市场强度
        {
            get { return this.Jz12_Dj_scqd + " [" + this.Jz12_Sj_scqd + "]"; }
        }
        public string Jz12_Sj_scqd = null;// 

        public string Jz12_Dj_fxjz = null;// 风险价值
        public string 风险价值
        {
            get { return this.Jz12_Dj_fxjz + " [" + this.Jz12_Sj_fxjz + "]"; }
        }
        public string Jz12_Sj_fxjz = null;// 

        public string Jz12_Dj_ldx = null;// 流动性
        public string 流动性
        {
            get { return this.Jz12_Dj_ldx + " [" + this.Jz12_Sj_ldx + "]"; }
        }
        public string Jz12_Sj_ldx = null;// 

        public string Jz12_Dj_aqbj = null;// 安全边际
        public string 安全边际
        {
            get { return this.Jz12_Dj_aqbj + " [" + this.Jz12_Sj_aqbj + "]"; }
        }
        public string Jz12_Sj_aqbj = null;// 

        public string Jz12_Dj_zhpj = null;// 综合评级星级
        public string 综合评级星级
        {
            get { return this.Jz12_Dj_zhpj + " [" + this.Jz12_Sj_zhpj + "]"; }
        }
        public string Jz12_Sj_zhpj = null;// 


        //投资评估
        public string Tz_Dj_zhyzpj = null;// 最后一致评级
        public string 最后一致评级
        {
            get { return this.Tz_Dj_zhyzpj + " [" + this.Tz_Sj_zhyzpj + "]"; }
        }
        public string Tz_Sj_zhyzpj = null;// 

        public string Tz_Dj_zhyzyc = null;// 最后一致预测
        public string 最后一致预测
        {
            get { return this.Tz_Dj_zhyzyc + " [" + this.Tz_Sj_zhyzyc + "]"; }
        }
        public string Tz_Sj_zhyzyc = null;// 

        public string Tz_Dj_zhpjdf = null;// 投资综合评级
        public string 投资综合评级
        {
            get { return this.Tz_Dj_zhpjdf + " [" + this.Tz_Sj_zhpjdf + "]"; }
        }
        public string Tz_Sj_zhpjdf = null;// 




        //成长质量评估
        public string Czzl_Dj_jzczbl = null;// 价值成长比率
        public string 价值成长比率
        {
            get { return this.Czzl_Dj_jzczbl + " [" + this.Czzl_Sj_jzczbl + "]"; }
        }
        public string Czzl_Sj_jzczbl = null;// 

        public string Czzl_Dj_wlsnylzz = null;// 未来3年赢利增长
        public string 未来3年赢利增长
        {
            get { return this.Czzl_Dj_wlsnylzz + " [" + this.Czzl_Sj_wlsnylzz + "]"; }
        }
        public string Czzl_Sj_wlsnylzz = null;// 

        public string Czzl_Dj_jbczl = null;// 基本成长率
        public string 基本成长率
        {
            get { return this.Czzl_Dj_jbczl + " [" + this.Czzl_Sj_jbczl + "]"; }
        }
        public string Czzl_Sj_jbczl = null;// 

        public string Czzl_Dj_jylrzzl = null;// 调整税后经营利润增长率
        public string 调整税后经营利润增长率
        {
            get { return this.Czzl_Dj_jylrzzl + " [" + this.Czzl_Sj_jylrzzl + "]"; }
        }
        public string Czzl_Sj_jylrzzl = null;// 

        public string Czzl_Dj_gdzjz = null;// 股东增加值
        public string 股东增加值
        {
            get { return this.Czzl_Dj_gdzjz + " [" + this.Czzl_Sj_gdzjz + "]"; }
        }
        public string Czzl_Sj_gdzjz = null;// 

        public string Czzl_Dj_wlzjz = null;// 未来增加值
        public string 未来增加值
        {
            get { return this.Czzl_Dj_wlzjz + " [" + this.Czzl_Sj_wlzjz + "]"; }
        }
        public string Czzl_Sj_wlzjz = null;// 

        public string Czzl_Dj_sczjz = null;// 市场增加值
        public string 市场增加值
        {
            get { return this.Czzl_Dj_sczjz + " [" + this.Czzl_Sj_sczjz + "]"; }
        }
        public string Czzl_Sj_sczjz = null;// 

        public string Czzl_Dj_zhpjdf = null;// 综合评级得分
        public string 综合评级得分
        {
            get { return this.Czzl_Dj_zhpjdf + " [" + this.Czzl_Sj_zhpjdf + "]"; }
        }
        public string Czzl_Sj_zhpjdf = null;// 



        public string Ths_gbdj = "N/A";  // 同花顺股本等级
        public string 同花顺股本等级
        {
            get
            {
                string degree;

                switch (this.Ths_gbdj.ToString())
                {
                    case "1": degree = "小盘"; break;
                    case "2": degree = "中盘"; break;
                    case "3": degree = "大盘"; break;

                    default: degree = "N/A"; break;
                }

                return degree;
            }
        }

        public string Ths_xj = "N/A";  // 同花顺星级
        public string 同花顺星级
        {
            get
            {
                string star;
                switch (this.Ths_xj.ToString())
                {
                    case "1": star = "★"; break;
                    case "2": star = "★★"; break;
                    case "3": star = "★★★"; break;
                    case "4": star = "★★★★"; break;
                    case "5": star = "★★★★★"; break;
                    default: star = "N/A"; break;
                }

                return star;
            }
        }

    }
}
