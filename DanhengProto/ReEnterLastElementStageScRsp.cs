using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D8F RID: 3471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReEnterLastElementStageScRsp : IMessage<ReEnterLastElementStageScRsp>, IMessage, IEquatable<ReEnterLastElementStageScRsp>, IDeepCloneable<ReEnterLastElementStageScRsp>, IBufferMessage
	{
		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x06009AF6 RID: 39670 RVA: 0x0019C31B File Offset: 0x0019A51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReEnterLastElementStageScRsp> Parser
		{
			get
			{
				return ReEnterLastElementStageScRsp._parser;
			}
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x0019C322 File Offset: 0x0019A522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReEnterLastElementStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x06009AF8 RID: 39672 RVA: 0x0019C334 File Offset: 0x0019A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReEnterLastElementStageScRsp.Descriptor;
			}
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x0019C33B File Offset: 0x0019A53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReEnterLastElementStageScRsp()
		{
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x0019C344 File Offset: 0x0019A544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReEnterLastElementStageScRsp(ReEnterLastElementStageScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x0019C39C File Offset: 0x0019A59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReEnterLastElementStageScRsp Clone()
		{
			return new ReEnterLastElementStageScRsp(this);
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x06009AFC RID: 39676 RVA: 0x0019C3A4 File Offset: 0x0019A5A4
		// (set) Token: 0x06009AFD RID: 39677 RVA: 0x0019C3AC File Offset: 0x0019A5AC
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

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x06009AFE RID: 39678 RVA: 0x0019C3B5 File Offset: 0x0019A5B5
		// (set) Token: 0x06009AFF RID: 39679 RVA: 0x0019C3BD File Offset: 0x0019A5BD
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

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x06009B00 RID: 39680 RVA: 0x0019C3C6 File Offset: 0x0019A5C6
		// (set) Token: 0x06009B01 RID: 39681 RVA: 0x0019C3CE File Offset: 0x0019A5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x0019C3D7 File Offset: 0x0019A5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReEnterLastElementStageScRsp);
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x0019C3E8 File Offset: 0x0019A5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReEnterLastElementStageScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x0019C448 File Offset: 0x0019A648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x0019C4B6 File Offset: 0x0019A6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x0019C4BE File Offset: 0x0019A6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x0019C4C8 File Offset: 0x0019A6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.StageId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.StageId);
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

		// Token: 0x06009B08 RID: 39688 RVA: 0x0019C540 File Offset: 0x0019A740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x0019C5B0 File Offset: 0x0019A7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReEnterLastElementStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x0019C62C File Offset: 0x0019A82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x0019C638 File Offset: 0x0019A838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 80U)
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
						this.StageId = input.ReadUInt32();
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

		// Token: 0x04003C1E RID: 15390
		private static readonly MessageParser<ReEnterLastElementStageScRsp> _parser = new MessageParser<ReEnterLastElementStageScRsp>(() => new ReEnterLastElementStageScRsp());

		// Token: 0x04003C1F RID: 15391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C20 RID: 15392
		public const int BattleInfoFieldNumber = 9;

		// Token: 0x04003C21 RID: 15393
		private SceneBattleInfo battleInfo_;

		// Token: 0x04003C22 RID: 15394
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04003C23 RID: 15395
		private uint retcode_;

		// Token: 0x04003C24 RID: 15396
		public const int StageIdFieldNumber = 10;

		// Token: 0x04003C25 RID: 15397
		private uint stageId_;
	}
}
