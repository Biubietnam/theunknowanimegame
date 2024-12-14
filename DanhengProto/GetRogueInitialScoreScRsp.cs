using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007C7 RID: 1991
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueInitialScoreScRsp : IMessage<GetRogueInitialScoreScRsp>, IMessage, IEquatable<GetRogueInitialScoreScRsp>, IDeepCloneable<GetRogueInitialScoreScRsp>, IBufferMessage
	{
		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x000ED193 File Offset: 0x000EB393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueInitialScoreScRsp> Parser
		{
			get
			{
				return GetRogueInitialScoreScRsp._parser;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060058CB RID: 22731 RVA: 0x000ED19A File Offset: 0x000EB39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueInitialScoreScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x000ED1AC File Offset: 0x000EB3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueInitialScoreScRsp.Descriptor;
			}
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x000ED1B3 File Offset: 0x000EB3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInitialScoreScRsp()
		{
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x000ED1BC File Offset: 0x000EB3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInitialScoreScRsp(GetRogueInitialScoreScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueScoreRewardInfo_ = ((other.rogueScoreRewardInfo_ != null) ? other.rogueScoreRewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x000ED208 File Offset: 0x000EB408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInitialScoreScRsp Clone()
		{
			return new GetRogueInitialScoreScRsp(this);
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x000ED210 File Offset: 0x000EB410
		// (set) Token: 0x060058D1 RID: 22737 RVA: 0x000ED218 File Offset: 0x000EB418
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

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x000ED221 File Offset: 0x000EB421
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x000ED229 File Offset: 0x000EB429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueScoreRewardInfo RogueScoreRewardInfo
		{
			get
			{
				return this.rogueScoreRewardInfo_;
			}
			set
			{
				this.rogueScoreRewardInfo_ = value;
			}
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x000ED232 File Offset: 0x000EB432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueInitialScoreScRsp);
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x000ED240 File Offset: 0x000EB440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueInitialScoreScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueScoreRewardInfo, other.RogueScoreRewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x000ED290 File Offset: 0x000EB490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num ^= this.RogueScoreRewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x000ED2E5 File Offset: 0x000EB4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x000ED2ED File Offset: 0x000EB4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x000ED2F8 File Offset: 0x000EB4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueScoreRewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x000ED354 File Offset: 0x000EB554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueScoreRewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueScoreRewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x000ED3AC File Offset: 0x000EB5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueInitialScoreScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueScoreRewardInfo_ != null)
			{
				if (this.rogueScoreRewardInfo_ == null)
				{
					this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
				}
				this.RogueScoreRewardInfo.MergeFrom(other.RogueScoreRewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x000ED414 File Offset: 0x000EB614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x000ED420 File Offset: 0x000EB620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueScoreRewardInfo_ == null)
						{
							this.RogueScoreRewardInfo = new RogueScoreRewardInfo();
						}
						input.ReadMessage(this.RogueScoreRewardInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400228E RID: 8846
		private static readonly MessageParser<GetRogueInitialScoreScRsp> _parser = new MessageParser<GetRogueInitialScoreScRsp>(() => new GetRogueInitialScoreScRsp());

		// Token: 0x0400228F RID: 8847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002290 RID: 8848
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04002291 RID: 8849
		private uint retcode_;

		// Token: 0x04002292 RID: 8850
		public const int RogueScoreRewardInfoFieldNumber = 15;

		// Token: 0x04002293 RID: 8851
		private RogueScoreRewardInfo rogueScoreRewardInfo_;
	}
}
