using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DCF RID: 3535
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RestartChallengePhaseScRsp : IMessage<RestartChallengePhaseScRsp>, IMessage, IEquatable<RestartChallengePhaseScRsp>, IDeepCloneable<RestartChallengePhaseScRsp>, IBufferMessage
	{
		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x06009E0C RID: 40460 RVA: 0x001A4F31 File Offset: 0x001A3131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RestartChallengePhaseScRsp> Parser
		{
			get
			{
				return RestartChallengePhaseScRsp._parser;
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x06009E0D RID: 40461 RVA: 0x001A4F38 File Offset: 0x001A3138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RestartChallengePhaseScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x06009E0E RID: 40462 RVA: 0x001A4F4A File Offset: 0x001A314A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestartChallengePhaseScRsp.Descriptor;
			}
		}

		// Token: 0x06009E0F RID: 40463 RVA: 0x001A4F51 File Offset: 0x001A3151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestartChallengePhaseScRsp()
		{
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x001A4F5C File Offset: 0x001A315C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestartChallengePhaseScRsp(RestartChallengePhaseScRsp other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x001A4FA8 File Offset: 0x001A31A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestartChallengePhaseScRsp Clone()
		{
			return new RestartChallengePhaseScRsp(this);
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x06009E12 RID: 40466 RVA: 0x001A4FB0 File Offset: 0x001A31B0
		// (set) Token: 0x06009E13 RID: 40467 RVA: 0x001A4FB8 File Offset: 0x001A31B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x06009E14 RID: 40468 RVA: 0x001A4FC1 File Offset: 0x001A31C1
		// (set) Token: 0x06009E15 RID: 40469 RVA: 0x001A4FC9 File Offset: 0x001A31C9
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

		// Token: 0x06009E16 RID: 40470 RVA: 0x001A4FD2 File Offset: 0x001A31D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestartChallengePhaseScRsp);
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x001A4FE0 File Offset: 0x001A31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RestartChallengePhaseScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x001A5030 File Offset: 0x001A3230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
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

		// Token: 0x06009E19 RID: 40473 RVA: 0x001A5085 File Offset: 0x001A3285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E1A RID: 40474 RVA: 0x001A508D File Offset: 0x001A328D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E1B RID: 40475 RVA: 0x001A5098 File Offset: 0x001A3298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E1C RID: 40476 RVA: 0x001A50F0 File Offset: 0x001A32F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
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

		// Token: 0x06009E1D RID: 40477 RVA: 0x001A5148 File Offset: 0x001A3348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RestartChallengePhaseScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E1E RID: 40478 RVA: 0x001A51B0 File Offset: 0x001A33B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x001A51BC File Offset: 0x001A33BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D6C RID: 15724
		private static readonly MessageParser<RestartChallengePhaseScRsp> _parser = new MessageParser<RestartChallengePhaseScRsp>(() => new RestartChallengePhaseScRsp());

		// Token: 0x04003D6D RID: 15725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D6E RID: 15726
		public const int SceneFieldNumber = 6;

		// Token: 0x04003D6F RID: 15727
		private SceneInfo scene_;

		// Token: 0x04003D70 RID: 15728
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04003D71 RID: 15729
		private uint retcode_;
	}
}
