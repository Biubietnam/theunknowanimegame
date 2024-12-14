using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB5 RID: 4021
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournFinishInfo : IMessage<RogueTournFinishInfo>, IMessage, IEquatable<RogueTournFinishInfo>, IDeepCloneable<RogueTournFinishInfo>, IBufferMessage
	{
		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600B32B RID: 45867 RVA: 0x001E14F4 File Offset: 0x001DF6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournFinishInfo> Parser
		{
			get
			{
				return RogueTournFinishInfo._parser;
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600B32C RID: 45868 RVA: 0x001E14FB File Offset: 0x001DF6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournFinishInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600B32D RID: 45869 RVA: 0x001E150D File Offset: 0x001DF70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournFinishInfo.Descriptor;
			}
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x001E1514 File Offset: 0x001DF714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFinishInfo()
		{
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x001E151C File Offset: 0x001DF71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFinishInfo(RogueTournFinishInfo other) : this()
		{
			this.nFEIIDHDENB_ = ((other.nFEIIDHDENB_ != null) ? other.nFEIIDHDENB_.Clone() : null);
			this.rogueLineupInfo_ = ((other.rogueLineupInfo_ != null) ? other.rogueLineupInfo_.Clone() : null);
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.lAIOKLJNPFO_ = ((other.lAIOKLJNPFO_ != null) ? other.lAIOKLJNPFO_.Clone() : null);
			this.dPAFCHMPEJC_ = ((other.dPAFCHMPEJC_ != null) ? other.dPAFCHMPEJC_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x001E15CC File Offset: 0x001DF7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFinishInfo Clone()
		{
			return new RogueTournFinishInfo(this);
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600B331 RID: 45873 RVA: 0x001E15D4 File Offset: 0x001DF7D4
		// (set) Token: 0x0600B332 RID: 45874 RVA: 0x001E15DC File Offset: 0x001DF7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDLIMIHCKFI NFEIIDHDENB
		{
			get
			{
				return this.nFEIIDHDENB_;
			}
			set
			{
				this.nFEIIDHDENB_ = value;
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600B333 RID: 45875 RVA: 0x001E15E5 File Offset: 0x001DF7E5
		// (set) Token: 0x0600B334 RID: 45876 RVA: 0x001E15ED File Offset: 0x001DF7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo RogueLineupInfo
		{
			get
			{
				return this.rogueLineupInfo_;
			}
			set
			{
				this.rogueLineupInfo_ = value;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600B335 RID: 45877 RVA: 0x001E15F6 File Offset: 0x001DF7F6
		// (set) Token: 0x0600B336 RID: 45878 RVA: 0x001E15FE File Offset: 0x001DF7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo RogueTournCurInfo
		{
			get
			{
				return this.rogueTournCurInfo_;
			}
			set
			{
				this.rogueTournCurInfo_ = value;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600B337 RID: 45879 RVA: 0x001E1607 File Offset: 0x001DF807
		// (set) Token: 0x0600B338 RID: 45880 RVA: 0x001E160F File Offset: 0x001DF80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJDLBJHAPMJ LAIOKLJNPFO
		{
			get
			{
				return this.lAIOKLJNPFO_;
			}
			set
			{
				this.lAIOKLJNPFO_ = value;
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600B339 RID: 45881 RVA: 0x001E1618 File Offset: 0x001DF818
		// (set) Token: 0x0600B33A RID: 45882 RVA: 0x001E1620 File Offset: 0x001DF820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PFJOGHHDEAH DPAFCHMPEJC
		{
			get
			{
				return this.dPAFCHMPEJC_;
			}
			set
			{
				this.dPAFCHMPEJC_ = value;
			}
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x001E1629 File Offset: 0x001DF829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournFinishInfo);
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x001E1638 File Offset: 0x001DF838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournFinishInfo other)
		{
			return other != null && (other == this || (object.Equals(this.NFEIIDHDENB, other.NFEIIDHDENB) && object.Equals(this.RogueLineupInfo, other.RogueLineupInfo) && object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && object.Equals(this.LAIOKLJNPFO, other.LAIOKLJNPFO) && object.Equals(this.DPAFCHMPEJC, other.DPAFCHMPEJC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x001E16CC File Offset: 0x001DF8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.nFEIIDHDENB_ != null)
			{
				num ^= this.NFEIIDHDENB.GetHashCode();
			}
			if (this.rogueLineupInfo_ != null)
			{
				num ^= this.RogueLineupInfo.GetHashCode();
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				num ^= this.LAIOKLJNPFO.GetHashCode();
			}
			if (this.dPAFCHMPEJC_ != null)
			{
				num ^= this.DPAFCHMPEJC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x001E1760 File Offset: 0x001DF960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x001E1768 File Offset: 0x001DF968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x001E1774 File Offset: 0x001DF974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this.rogueLineupInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueLineupInfo);
			}
			if (this.dPAFCHMPEJC_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.DPAFCHMPEJC);
			}
			if (this.nFEIIDHDENB_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.NFEIIDHDENB);
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.LAIOKLJNPFO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x001E1824 File Offset: 0x001DFA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.nFEIIDHDENB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NFEIIDHDENB);
			}
			if (this.rogueLineupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueLineupInfo);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LAIOKLJNPFO);
			}
			if (this.dPAFCHMPEJC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DPAFCHMPEJC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x001E18C4 File Offset: 0x001DFAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournFinishInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.nFEIIDHDENB_ != null)
			{
				if (this.nFEIIDHDENB_ == null)
				{
					this.NFEIIDHDENB = new PDLIMIHCKFI();
				}
				this.NFEIIDHDENB.MergeFrom(other.NFEIIDHDENB);
			}
			if (other.rogueLineupInfo_ != null)
			{
				if (this.rogueLineupInfo_ == null)
				{
					this.RogueLineupInfo = new LineupInfo();
				}
				this.RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueTournCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			if (other.lAIOKLJNPFO_ != null)
			{
				if (this.lAIOKLJNPFO_ == null)
				{
					this.LAIOKLJNPFO = new KJDLBJHAPMJ();
				}
				this.LAIOKLJNPFO.MergeFrom(other.LAIOKLJNPFO);
			}
			if (other.dPAFCHMPEJC_ != null)
			{
				if (this.dPAFCHMPEJC_ == null)
				{
					this.DPAFCHMPEJC = new PFJOGHHDEAH();
				}
				this.DPAFCHMPEJC.MergeFrom(other.DPAFCHMPEJC);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x001E19C8 File Offset: 0x001DFBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x001E19D4 File Offset: 0x001DFBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 82U)
				{
					if (num == 10U)
					{
						if (this.rogueTournCurInfo_ == null)
						{
							this.RogueTournCurInfo = new RogueTournCurInfo();
						}
						input.ReadMessage(this.RogueTournCurInfo);
						continue;
					}
					if (num == 82U)
					{
						if (this.rogueLineupInfo_ == null)
						{
							this.RogueLineupInfo = new LineupInfo();
						}
						input.ReadMessage(this.RogueLineupInfo);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.dPAFCHMPEJC_ == null)
						{
							this.DPAFCHMPEJC = new PFJOGHHDEAH();
						}
						input.ReadMessage(this.DPAFCHMPEJC);
						continue;
					}
					if (num == 114U)
					{
						if (this.nFEIIDHDENB_ == null)
						{
							this.NFEIIDHDENB = new PDLIMIHCKFI();
						}
						input.ReadMessage(this.NFEIIDHDENB);
						continue;
					}
					if (num == 122U)
					{
						if (this.lAIOKLJNPFO_ == null)
						{
							this.LAIOKLJNPFO = new KJDLBJHAPMJ();
						}
						input.ReadMessage(this.LAIOKLJNPFO);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048C2 RID: 18626
		private static readonly MessageParser<RogueTournFinishInfo> _parser = new MessageParser<RogueTournFinishInfo>(() => new RogueTournFinishInfo());

		// Token: 0x040048C3 RID: 18627
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048C4 RID: 18628
		public const int NFEIIDHDENBFieldNumber = 14;

		// Token: 0x040048C5 RID: 18629
		private PDLIMIHCKFI nFEIIDHDENB_;

		// Token: 0x040048C6 RID: 18630
		public const int RogueLineupInfoFieldNumber = 10;

		// Token: 0x040048C7 RID: 18631
		private LineupInfo rogueLineupInfo_;

		// Token: 0x040048C8 RID: 18632
		public const int RogueTournCurInfoFieldNumber = 1;

		// Token: 0x040048C9 RID: 18633
		private RogueTournCurInfo rogueTournCurInfo_;

		// Token: 0x040048CA RID: 18634
		public const int LAIOKLJNPFOFieldNumber = 15;

		// Token: 0x040048CB RID: 18635
		private KJDLBJHAPMJ lAIOKLJNPFO_;

		// Token: 0x040048CC RID: 18636
		public const int DPAFCHMPEJCFieldNumber = 12;

		// Token: 0x040048CD RID: 18637
		private PFJOGHHDEAH dPAFCHMPEJC_;
	}
}
