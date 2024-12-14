using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013FF RID: 5119
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateTrackMainMissionIdScRsp : IMessage<UpdateTrackMainMissionIdScRsp>, IMessage, IEquatable<UpdateTrackMainMissionIdScRsp>, IDeepCloneable<UpdateTrackMainMissionIdScRsp>, IBufferMessage
	{
		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x0600E43E RID: 58430 RVA: 0x0025EE67 File Offset: 0x0025D067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateTrackMainMissionIdScRsp> Parser
		{
			get
			{
				return UpdateTrackMainMissionIdScRsp._parser;
			}
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x0600E43F RID: 58431 RVA: 0x0025EE6E File Offset: 0x0025D06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateTrackMainMissionIdScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x0600E440 RID: 58432 RVA: 0x0025EE80 File Offset: 0x0025D080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateTrackMainMissionIdScRsp.Descriptor;
			}
		}

		// Token: 0x0600E441 RID: 58433 RVA: 0x0025EE87 File Offset: 0x0025D087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTrackMainMissionIdScRsp()
		{
		}

		// Token: 0x0600E442 RID: 58434 RVA: 0x0025EE8F File Offset: 0x0025D08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTrackMainMissionIdScRsp(UpdateTrackMainMissionIdScRsp other) : this()
		{
			this.trackMissionId_ = other.trackMissionId_;
			this.prevTrackMissionId_ = other.prevTrackMissionId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E443 RID: 58435 RVA: 0x0025EECC File Offset: 0x0025D0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTrackMainMissionIdScRsp Clone()
		{
			return new UpdateTrackMainMissionIdScRsp(this);
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x0600E444 RID: 58436 RVA: 0x0025EED4 File Offset: 0x0025D0D4
		// (set) Token: 0x0600E445 RID: 58437 RVA: 0x0025EEDC File Offset: 0x0025D0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TrackMissionId
		{
			get
			{
				return this.trackMissionId_;
			}
			set
			{
				this.trackMissionId_ = value;
			}
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x0600E446 RID: 58438 RVA: 0x0025EEE5 File Offset: 0x0025D0E5
		// (set) Token: 0x0600E447 RID: 58439 RVA: 0x0025EEED File Offset: 0x0025D0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PrevTrackMissionId
		{
			get
			{
				return this.prevTrackMissionId_;
			}
			set
			{
				this.prevTrackMissionId_ = value;
			}
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x0600E448 RID: 58440 RVA: 0x0025EEF6 File Offset: 0x0025D0F6
		// (set) Token: 0x0600E449 RID: 58441 RVA: 0x0025EEFE File Offset: 0x0025D0FE
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

		// Token: 0x0600E44A RID: 58442 RVA: 0x0025EF07 File Offset: 0x0025D107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateTrackMainMissionIdScRsp);
		}

		// Token: 0x0600E44B RID: 58443 RVA: 0x0025EF18 File Offset: 0x0025D118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateTrackMainMissionIdScRsp other)
		{
			return other != null && (other == this || (this.TrackMissionId == other.TrackMissionId && this.PrevTrackMissionId == other.PrevTrackMissionId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E44C RID: 58444 RVA: 0x0025EF74 File Offset: 0x0025D174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrackMissionId != 0U)
			{
				num ^= this.TrackMissionId.GetHashCode();
			}
			if (this.PrevTrackMissionId != 0U)
			{
				num ^= this.PrevTrackMissionId.GetHashCode();
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

		// Token: 0x0600E44D RID: 58445 RVA: 0x0025EFE5 File Offset: 0x0025D1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x0025EFED File Offset: 0x0025D1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E44F RID: 58447 RVA: 0x0025EFF8 File Offset: 0x0025D1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrackMissionId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TrackMissionId);
			}
			if (this.PrevTrackMissionId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PrevTrackMissionId);
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

		// Token: 0x0600E450 RID: 58448 RVA: 0x0025F070 File Offset: 0x0025D270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrackMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TrackMissionId);
			}
			if (this.PrevTrackMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PrevTrackMissionId);
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

		// Token: 0x0600E451 RID: 58449 RVA: 0x0025F0E0 File Offset: 0x0025D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateTrackMainMissionIdScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrackMissionId != 0U)
			{
				this.TrackMissionId = other.TrackMissionId;
			}
			if (other.PrevTrackMissionId != 0U)
			{
				this.PrevTrackMissionId = other.PrevTrackMissionId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x0025F144 File Offset: 0x0025D344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x0025F150 File Offset: 0x0025D350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
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
						this.PrevTrackMissionId = input.ReadUInt32();
					}
				}
				else
				{
					this.TrackMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005AAC RID: 23212
		private static readonly MessageParser<UpdateTrackMainMissionIdScRsp> _parser = new MessageParser<UpdateTrackMainMissionIdScRsp>(() => new UpdateTrackMainMissionIdScRsp());

		// Token: 0x04005AAD RID: 23213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AAE RID: 23214
		public const int TrackMissionIdFieldNumber = 4;

		// Token: 0x04005AAF RID: 23215
		private uint trackMissionId_;

		// Token: 0x04005AB0 RID: 23216
		public const int PrevTrackMissionIdFieldNumber = 6;

		// Token: 0x04005AB1 RID: 23217
		private uint prevTrackMissionId_;

		// Token: 0x04005AB2 RID: 23218
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04005AB3 RID: 23219
		private uint retcode_;
	}
}
