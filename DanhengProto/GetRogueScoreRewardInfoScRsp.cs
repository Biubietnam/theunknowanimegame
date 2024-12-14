using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007CB RID: 1995
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueScoreRewardInfoScRsp : IMessage<GetRogueScoreRewardInfoScRsp>, IMessage, IEquatable<GetRogueScoreRewardInfoScRsp>, IDeepCloneable<GetRogueScoreRewardInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060058F4 RID: 22772 RVA: 0x000ED6F7 File Offset: 0x000EB8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueScoreRewardInfoScRsp> Parser
		{
			get
			{
				return GetRogueScoreRewardInfoScRsp._parser;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060058F5 RID: 22773 RVA: 0x000ED6FE File Offset: 0x000EB8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueScoreRewardInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060058F6 RID: 22774 RVA: 0x000ED710 File Offset: 0x000EB910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueScoreRewardInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x000ED717 File Offset: 0x000EB917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueScoreRewardInfoScRsp()
		{
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x000ED720 File Offset: 0x000EB920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueScoreRewardInfoScRsp(GetRogueScoreRewardInfoScRsp other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x000ED76C File Offset: 0x000EB96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueScoreRewardInfoScRsp Clone()
		{
			return new GetRogueScoreRewardInfoScRsp(this);
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x000ED774 File Offset: 0x000EB974
		// (set) Token: 0x060058FB RID: 22779 RVA: 0x000ED77C File Offset: 0x000EB97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x000ED785 File Offset: 0x000EB985
		// (set) Token: 0x060058FD RID: 22781 RVA: 0x000ED78D File Offset: 0x000EB98D
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

		// Token: 0x060058FE RID: 22782 RVA: 0x000ED796 File Offset: 0x000EB996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueScoreRewardInfoScRsp);
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x000ED7A4 File Offset: 0x000EB9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueScoreRewardInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x000ED7F4 File Offset: 0x000EB9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
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

		// Token: 0x06005901 RID: 22785 RVA: 0x000ED849 File Offset: 0x000EBA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x000ED851 File Offset: 0x000EBA51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x000ED85C File Offset: 0x000EBA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Info);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x000ED8B8 File Offset: 0x000EBAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
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

		// Token: 0x06005905 RID: 22789 RVA: 0x000ED910 File Offset: 0x000EBB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueScoreRewardInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new RogueScoreRewardInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x000ED978 File Offset: 0x000EBB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x000ED984 File Offset: 0x000EBB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 104U)
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
					if (this.info_ == null)
					{
						this.Info = new RogueScoreRewardInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04002298 RID: 8856
		private static readonly MessageParser<GetRogueScoreRewardInfoScRsp> _parser = new MessageParser<GetRogueScoreRewardInfoScRsp>(() => new GetRogueScoreRewardInfoScRsp());

		// Token: 0x04002299 RID: 8857
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400229A RID: 8858
		public const int InfoFieldNumber = 11;

		// Token: 0x0400229B RID: 8859
		private RogueScoreRewardInfo info_;

		// Token: 0x0400229C RID: 8860
		public const int RetcodeFieldNumber = 13;

		// Token: 0x0400229D RID: 8861
		private uint retcode_;
	}
}
