using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200105D RID: 4189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEnterStageScRsp : IMessage<SceneEnterStageScRsp>, IMessage, IEquatable<SceneEnterStageScRsp>, IDeepCloneable<SceneEnterStageScRsp>, IBufferMessage
	{
		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600BA89 RID: 47753 RVA: 0x001F5689 File Offset: 0x001F3889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEnterStageScRsp> Parser
		{
			get
			{
				return SceneEnterStageScRsp._parser;
			}
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x001F5690 File Offset: 0x001F3890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEnterStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600BA8B RID: 47755 RVA: 0x001F56A2 File Offset: 0x001F38A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEnterStageScRsp.Descriptor;
			}
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x001F56A9 File Offset: 0x001F38A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEnterStageScRsp()
		{
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x001F56B4 File Offset: 0x001F38B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEnterStageScRsp(SceneEnterStageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x001F5700 File Offset: 0x001F3900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEnterStageScRsp Clone()
		{
			return new SceneEnterStageScRsp(this);
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600BA8F RID: 47759 RVA: 0x001F5708 File Offset: 0x001F3908
		// (set) Token: 0x0600BA90 RID: 47760 RVA: 0x001F5710 File Offset: 0x001F3910
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

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600BA91 RID: 47761 RVA: 0x001F5719 File Offset: 0x001F3919
		// (set) Token: 0x0600BA92 RID: 47762 RVA: 0x001F5721 File Offset: 0x001F3921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x001F572A File Offset: 0x001F392A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEnterStageScRsp);
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x001F5738 File Offset: 0x001F3938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEnterStageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BattleInfo, other.BattleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x001F5788 File Offset: 0x001F3988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA96 RID: 47766 RVA: 0x001F57DD File Offset: 0x001F39DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x001F57E5 File Offset: 0x001F39E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA98 RID: 47768 RVA: 0x001F57F0 File Offset: 0x001F39F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA99 RID: 47769 RVA: 0x001F584C File Offset: 0x001F3A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x001F58A4 File Offset: 0x001F3AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEnterStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x001F590C File Offset: 0x001F3B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA9C RID: 47772 RVA: 0x001F5918 File Offset: 0x001F3B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 112U)
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
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x04004BA6 RID: 19366
		private static readonly MessageParser<SceneEnterStageScRsp> _parser = new MessageParser<SceneEnterStageScRsp>(() => new SceneEnterStageScRsp());

		// Token: 0x04004BA7 RID: 19367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BA8 RID: 19368
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04004BA9 RID: 19369
		private uint retcode_;

		// Token: 0x04004BAA RID: 19370
		public const int BattleInfoFieldNumber = 4;

		// Token: 0x04004BAB RID: 19371
		private SceneBattleInfo battleInfo_;
	}
}
