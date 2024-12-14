using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001053 RID: 4179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneCastSkillCostMpScRsp : IMessage<SceneCastSkillCostMpScRsp>, IMessage, IEquatable<SceneCastSkillCostMpScRsp>, IDeepCloneable<SceneCastSkillCostMpScRsp>, IBufferMessage
	{
		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x001F3C09 File Offset: 0x001F1E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneCastSkillCostMpScRsp> Parser
		{
			get
			{
				return SceneCastSkillCostMpScRsp._parser;
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600BA05 RID: 47621 RVA: 0x001F3C10 File Offset: 0x001F1E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneCastSkillCostMpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600BA06 RID: 47622 RVA: 0x001F3C22 File Offset: 0x001F1E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneCastSkillCostMpScRsp.Descriptor;
			}
		}

		// Token: 0x0600BA07 RID: 47623 RVA: 0x001F3C29 File Offset: 0x001F1E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCostMpScRsp()
		{
		}

		// Token: 0x0600BA08 RID: 47624 RVA: 0x001F3C31 File Offset: 0x001F1E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCostMpScRsp(SceneCastSkillCostMpScRsp other) : this()
		{
			this.castEntityId_ = other.castEntityId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA09 RID: 47625 RVA: 0x001F3C62 File Offset: 0x001F1E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneCastSkillCostMpScRsp Clone()
		{
			return new SceneCastSkillCostMpScRsp(this);
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600BA0A RID: 47626 RVA: 0x001F3C6A File Offset: 0x001F1E6A
		// (set) Token: 0x0600BA0B RID: 47627 RVA: 0x001F3C72 File Offset: 0x001F1E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CastEntityId
		{
			get
			{
				return this.castEntityId_;
			}
			set
			{
				this.castEntityId_ = value;
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600BA0C RID: 47628 RVA: 0x001F3C7B File Offset: 0x001F1E7B
		// (set) Token: 0x0600BA0D RID: 47629 RVA: 0x001F3C83 File Offset: 0x001F1E83
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

		// Token: 0x0600BA0E RID: 47630 RVA: 0x001F3C8C File Offset: 0x001F1E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneCastSkillCostMpScRsp);
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x001F3C9A File Offset: 0x001F1E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneCastSkillCostMpScRsp other)
		{
			return other != null && (other == this || (this.CastEntityId == other.CastEntityId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x001F3CD8 File Offset: 0x001F1ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CastEntityId != 0U)
			{
				num ^= this.CastEntityId.GetHashCode();
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

		// Token: 0x0600BA11 RID: 47633 RVA: 0x001F3D30 File Offset: 0x001F1F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BA12 RID: 47634 RVA: 0x001F3D38 File Offset: 0x001F1F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA13 RID: 47635 RVA: 0x001F3D44 File Offset: 0x001F1F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CastEntityId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CastEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x001F3DA0 File Offset: 0x001F1FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CastEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CastEntityId);
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

		// Token: 0x0600BA15 RID: 47637 RVA: 0x001F3DF8 File Offset: 0x001F1FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneCastSkillCostMpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CastEntityId != 0U)
			{
				this.CastEntityId = other.CastEntityId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x001F3E48 File Offset: 0x001F2048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x001F3E54 File Offset: 0x001F2054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CastEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004B65 RID: 19301
		private static readonly MessageParser<SceneCastSkillCostMpScRsp> _parser = new MessageParser<SceneCastSkillCostMpScRsp>(() => new SceneCastSkillCostMpScRsp());

		// Token: 0x04004B66 RID: 19302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B67 RID: 19303
		public const int CastEntityIdFieldNumber = 13;

		// Token: 0x04004B68 RID: 19304
		private uint castEntityId_;

		// Token: 0x04004B69 RID: 19305
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004B6A RID: 19306
		private uint retcode_;
	}
}
