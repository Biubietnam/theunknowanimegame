using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000039 RID: 57
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivityRaidPlacingGameScRsp : IMessage<ActivityRaidPlacingGameScRsp>, IMessage, IEquatable<ActivityRaidPlacingGameScRsp>, IDeepCloneable<ActivityRaidPlacingGameScRsp>, IBufferMessage
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00007499 File Offset: 0x00005699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityRaidPlacingGameScRsp> Parser
		{
			get
			{
				return ActivityRaidPlacingGameScRsp._parser;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000074A0 File Offset: 0x000056A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ActivityRaidPlacingGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000074B2 File Offset: 0x000056B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityRaidPlacingGameScRsp.Descriptor;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000074B9 File Offset: 0x000056B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRaidPlacingGameScRsp()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000074C1 File Offset: 0x000056C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRaidPlacingGameScRsp(ActivityRaidPlacingGameScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bFBCBCADGOJ_ = other.bFBCBCADGOJ_;
			this.mHJBFLBMGMH_ = other.mHJBFLBMGMH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000074FE File Offset: 0x000056FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityRaidPlacingGameScRsp Clone()
		{
			return new ActivityRaidPlacingGameScRsp(this);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00007506 File Offset: 0x00005706
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000750E File Offset: 0x0000570E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00007517 File Offset: 0x00005717
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000751F File Offset: 0x0000571F
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00007528 File Offset: 0x00005728
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00007530 File Offset: 0x00005730
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

		// Token: 0x0600023E RID: 574 RVA: 0x00007539 File Offset: 0x00005739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityRaidPlacingGameScRsp);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00007548 File Offset: 0x00005748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityRaidPlacingGameScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.BFBCBCADGOJ == other.BFBCBCADGOJ && this.MHJBFLBMGMH == other.MHJBFLBMGMH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000075A4 File Offset: 0x000057A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x06000241 RID: 577 RVA: 0x00007615 File Offset: 0x00005815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000761D File Offset: 0x0000581D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00007628 File Offset: 0x00005828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MHJBFLBMGMH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MHJBFLBMGMH);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.BFBCBCADGOJ != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BFBCBCADGOJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000076A0 File Offset: 0x000058A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x06000245 RID: 581 RVA: 0x00007710 File Offset: 0x00005910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityRaidPlacingGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
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

		// Token: 0x06000246 RID: 582 RVA: 0x00007774 File Offset: 0x00005974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00007780 File Offset: 0x00005980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BFBCBCADGOJ = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.MHJBFLBMGMH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040000C7 RID: 199
		private static readonly MessageParser<ActivityRaidPlacingGameScRsp> _parser = new MessageParser<ActivityRaidPlacingGameScRsp>(() => new ActivityRaidPlacingGameScRsp());

		// Token: 0x040000C8 RID: 200
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000C9 RID: 201
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040000CA RID: 202
		private uint retcode_;

		// Token: 0x040000CB RID: 203
		public const int BFBCBCADGOJFieldNumber = 13;

		// Token: 0x040000CC RID: 204
		private uint bFBCBCADGOJ_;

		// Token: 0x040000CD RID: 205
		public const int MHJBFLBMGMHFieldNumber = 2;

		// Token: 0x040000CE RID: 206
		private uint mHJBFLBMGMH_;
	}
}
