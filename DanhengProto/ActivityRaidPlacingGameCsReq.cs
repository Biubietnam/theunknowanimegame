using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000037 RID: 55
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivityRaidPlacingGameCsReq : IMessage<ActivityRaidPlacingGameCsReq>, IMessage, IEquatable<ActivityRaidPlacingGameCsReq>, IDeepCloneable<ActivityRaidPlacingGameCsReq>, IBufferMessage
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000705F File Offset: 0x0000525F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityRaidPlacingGameCsReq> Parser
		{
			get
			{
				return ActivityRaidPlacingGameCsReq._parser;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00007066 File Offset: 0x00005266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ActivityRaidPlacingGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00007078 File Offset: 0x00005278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRaidPlacingGameCsReq.Descriptor;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000707F File Offset: 0x0000527F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRaidPlacingGameCsReq()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00007088 File Offset: 0x00005288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRaidPlacingGameCsReq(ActivityRaidPlacingGameCsReq other) : this()
		{
			this.jLDHAKPMJNM_ = ((other.jLDHAKPMJNM_ != null) ? other.jLDHAKPMJNM_.Clone() : null);
			this.bFBCBCADGOJ_ = other.bFBCBCADGOJ_;
			this.mHJBFLBMGMH_ = other.mHJBFLBMGMH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000070E0 File Offset: 0x000052E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRaidPlacingGameCsReq Clone()
		{
			return new ActivityRaidPlacingGameCsReq(this);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000070E8 File Offset: 0x000052E8
		// (set) Token: 0x06000220 RID: 544 RVA: 0x000070F0 File Offset: 0x000052F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyPlacingShip JLDHAKPMJNM
		{
			get
			{
				return this.jLDHAKPMJNM_;
			}
			set
			{
				this.jLDHAKPMJNM_ = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000070F9 File Offset: 0x000052F9
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00007101 File Offset: 0x00005301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BFBCBCADGOJ
		{
			get
			{
				return this.bFBCBCADGOJ_;
			}
			set
			{
				this.bFBCBCADGOJ_ = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000710A File Offset: 0x0000530A
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00007112 File Offset: 0x00005312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MHJBFLBMGMH
		{
			get
			{
				return this.mHJBFLBMGMH_;
			}
			set
			{
				this.mHJBFLBMGMH_ = value;
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000711B File Offset: 0x0000531B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRaidPlacingGameCsReq);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000712C File Offset: 0x0000532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRaidPlacingGameCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.JLDHAKPMJNM, other.JLDHAKPMJNM) && this.BFBCBCADGOJ == other.BFBCBCADGOJ && this.MHJBFLBMGMH == other.MHJBFLBMGMH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000718C File Offset: 0x0000538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.jLDHAKPMJNM_ != null)
			{
				num ^= this.JLDHAKPMJNM.GetHashCode();
			}
			if (this.BFBCBCADGOJ != 0U)
			{
				num ^= this.BFBCBCADGOJ.GetHashCode();
			}
			if (this.MHJBFLBMGMH != 0U)
			{
				num ^= this.MHJBFLBMGMH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000071FA File Offset: 0x000053FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00007202 File Offset: 0x00005402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000720C File Offset: 0x0000540C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BFBCBCADGOJ != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BFBCBCADGOJ);
			}
			if (this.jLDHAKPMJNM_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.JLDHAKPMJNM);
			}
			if (this.MHJBFLBMGMH != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MHJBFLBMGMH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00007284 File Offset: 0x00005484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.jLDHAKPMJNM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JLDHAKPMJNM);
			}
			if (this.BFBCBCADGOJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BFBCBCADGOJ);
			}
			if (this.MHJBFLBMGMH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MHJBFLBMGMH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000072F4 File Offset: 0x000054F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityRaidPlacingGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.jLDHAKPMJNM_ != null)
			{
				if (this.jLDHAKPMJNM_ == null)
				{
					this.JLDHAKPMJNM = new AlleyPlacingShip();
				}
				this.JLDHAKPMJNM.MergeFrom(other.JLDHAKPMJNM);
			}
			if (other.BFBCBCADGOJ != 0U)
			{
				this.BFBCBCADGOJ = other.BFBCBCADGOJ;
			}
			if (other.MHJBFLBMGMH != 0U)
			{
				this.MHJBFLBMGMH = other.MHJBFLBMGMH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00007370 File Offset: 0x00005570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000737C File Offset: 0x0000557C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 82U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MHJBFLBMGMH = input.ReadUInt32();
						}
					}
					else
					{
						if (this.jLDHAKPMJNM_ == null)
						{
							this.JLDHAKPMJNM = new AlleyPlacingShip();
						}
						input.ReadMessage(this.JLDHAKPMJNM);
					}
				}
				else
				{
					this.BFBCBCADGOJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040000BE RID: 190
		private static readonly MessageParser<ActivityRaidPlacingGameCsReq> _parser = new MessageParser<ActivityRaidPlacingGameCsReq>(() => new ActivityRaidPlacingGameCsReq());

		// Token: 0x040000BF RID: 191
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000C0 RID: 192
		public const int JLDHAKPMJNMFieldNumber = 10;

		// Token: 0x040000C1 RID: 193
		private AlleyPlacingShip jLDHAKPMJNM_;

		// Token: 0x040000C2 RID: 194
		public const int BFBCBCADGOJFieldNumber = 2;

		// Token: 0x040000C3 RID: 195
		private uint bFBCBCADGOJ_;

		// Token: 0x040000C4 RID: 196
		public const int MHJBFLBMGMHFieldNumber = 14;

		// Token: 0x040000C5 RID: 197
		private uint mHJBFLBMGMH_;
	}
}
