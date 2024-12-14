using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF5 RID: 3829
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicQueryScRsp : IMessage<RogueMagicQueryScRsp>, IMessage, IEquatable<RogueMagicQueryScRsp>, IDeepCloneable<RogueMagicQueryScRsp>, IBufferMessage
	{
		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0600AB03 RID: 43779 RVA: 0x001CCAEB File Offset: 0x001CACEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicQueryScRsp> Parser
		{
			get
			{
				return RogueMagicQueryScRsp._parser;
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x001CCAF2 File Offset: 0x001CACF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicQueryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x0600AB05 RID: 43781 RVA: 0x001CCB04 File Offset: 0x001CAD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicQueryScRsp.Descriptor;
			}
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x001CCB0B File Offset: 0x001CAD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicQueryScRsp()
		{
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x001CCB14 File Offset: 0x001CAD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicQueryScRsp(RogueMagicQueryScRsp other) : this()
		{
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x001CCB7C File Offset: 0x001CAD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicQueryScRsp Clone()
		{
			return new RogueMagicQueryScRsp(this);
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x0600AB09 RID: 43785 RVA: 0x001CCB84 File Offset: 0x001CAD84
		// (set) Token: 0x0600AB0A RID: 43786 RVA: 0x001CCB8C File Offset: 0x001CAD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurInfo RogueTournCurInfo
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

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x0600AB0B RID: 43787 RVA: 0x001CCB95 File Offset: 0x001CAD95
		// (set) Token: 0x0600AB0C RID: 43788 RVA: 0x001CCB9D File Offset: 0x001CAD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGetInfo RogueGetInfo
		{
			get
			{
				return this.rogueGetInfo_;
			}
			set
			{
				this.rogueGetInfo_ = value;
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x0600AB0D RID: 43789 RVA: 0x001CCBA6 File Offset: 0x001CADA6
		// (set) Token: 0x0600AB0E RID: 43790 RVA: 0x001CCBAE File Offset: 0x001CADAE
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

		// Token: 0x0600AB0F RID: 43791 RVA: 0x001CCBB7 File Offset: 0x001CADB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicQueryScRsp);
		}

		// Token: 0x0600AB10 RID: 43792 RVA: 0x001CCBC8 File Offset: 0x001CADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicQueryScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && object.Equals(this.RogueGetInfo, other.RogueGetInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x001CCC2C File Offset: 0x001CAE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
			}
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x001CCC97 File Offset: 0x001CAE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x001CCC9F File Offset: 0x001CAE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x001CCCA8 File Offset: 0x001CAEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x001CCD20 File Offset: 0x001CAF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x001CCD90 File Offset: 0x001CAF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicQueryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueMagicCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			if (other.rogueGetInfo_ != null)
			{
				if (this.rogueGetInfo_ == null)
				{
					this.RogueGetInfo = new RogueMagicGetInfo();
				}
				this.RogueGetInfo.MergeFrom(other.RogueGetInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x001CCE24 File Offset: 0x001CB024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB18 RID: 43800 RVA: 0x001CCE30 File Offset: 0x001CB030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 26U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						if (this.rogueGetInfo_ == null)
						{
							this.RogueGetInfo = new RogueMagicGetInfo();
						}
						input.ReadMessage(this.RogueGetInfo);
					}
				}
				else
				{
					if (this.rogueTournCurInfo_ == null)
					{
						this.RogueTournCurInfo = new RogueMagicCurInfo();
					}
					input.ReadMessage(this.RogueTournCurInfo);
				}
			}
		}

		// Token: 0x040045CF RID: 17871
		private static readonly MessageParser<RogueMagicQueryScRsp> _parser = new MessageParser<RogueMagicQueryScRsp>(() => new RogueMagicQueryScRsp());

		// Token: 0x040045D0 RID: 17872
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045D1 RID: 17873
		public const int RogueTournCurInfoFieldNumber = 1;

		// Token: 0x040045D2 RID: 17874
		private RogueMagicCurInfo rogueTournCurInfo_;

		// Token: 0x040045D3 RID: 17875
		public const int RogueGetInfoFieldNumber = 3;

		// Token: 0x040045D4 RID: 17876
		private RogueMagicGetInfo rogueGetInfo_;

		// Token: 0x040045D5 RID: 17877
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040045D6 RID: 17878
		private uint retcode_;
	}
}
