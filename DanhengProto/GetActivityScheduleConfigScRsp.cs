using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005F9 RID: 1529
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetActivityScheduleConfigScRsp : IMessage<GetActivityScheduleConfigScRsp>, IMessage, IEquatable<GetActivityScheduleConfigScRsp>, IDeepCloneable<GetActivityScheduleConfigScRsp>, IBufferMessage
	{
		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x000BC187 File Offset: 0x000BA387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetActivityScheduleConfigScRsp> Parser
		{
			get
			{
				return GetActivityScheduleConfigScRsp._parser;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x000BC18E File Offset: 0x000BA38E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetActivityScheduleConfigScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x000BC1A0 File Offset: 0x000BA3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetActivityScheduleConfigScRsp.Descriptor;
			}
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x000BC1A7 File Offset: 0x000BA3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetActivityScheduleConfigScRsp()
		{
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x000BC1BA File Offset: 0x000BA3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetActivityScheduleConfigScRsp(GetActivityScheduleConfigScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.scheduleData_ = other.scheduleData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x000BC1F0 File Offset: 0x000BA3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetActivityScheduleConfigScRsp Clone()
		{
			return new GetActivityScheduleConfigScRsp(this);
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x000BC1F8 File Offset: 0x000BA3F8
		// (set) Token: 0x06004497 RID: 17559 RVA: 0x000BC200 File Offset: 0x000BA400
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

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x000BC209 File Offset: 0x000BA409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityScheduleData> ScheduleData
		{
			get
			{
				return this.scheduleData_;
			}
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x000BC211 File Offset: 0x000BA411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetActivityScheduleConfigScRsp);
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x000BC220 File Offset: 0x000BA420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetActivityScheduleConfigScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.scheduleData_.Equals(other.scheduleData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x000BC270 File Offset: 0x000BA470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.scheduleData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x000BC2BD File Offset: 0x000BA4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x000BC2C5 File Offset: 0x000BA4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x000BC2D0 File Offset: 0x000BA4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scheduleData_.WriteTo(ref output, GetActivityScheduleConfigScRsp._repeated_scheduleData_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x000BC320 File Offset: 0x000BA520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.scheduleData_.CalculateSize(GetActivityScheduleConfigScRsp._repeated_scheduleData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x000BC374 File Offset: 0x000BA574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetActivityScheduleConfigScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.scheduleData_.Add(other.scheduleData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x000BC3C1 File Offset: 0x000BA5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x000BC3CC File Offset: 0x000BA5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 24U)
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
					this.scheduleData_.AddEntriesFrom(ref input, GetActivityScheduleConfigScRsp._repeated_scheduleData_codec);
				}
			}
		}

		// Token: 0x04001B71 RID: 7025
		private static readonly MessageParser<GetActivityScheduleConfigScRsp> _parser = new MessageParser<GetActivityScheduleConfigScRsp>(() => new GetActivityScheduleConfigScRsp());

		// Token: 0x04001B72 RID: 7026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B73 RID: 7027
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04001B74 RID: 7028
		private uint retcode_;

		// Token: 0x04001B75 RID: 7029
		public const int ScheduleDataFieldNumber = 2;

		// Token: 0x04001B76 RID: 7030
		private static readonly FieldCodec<ActivityScheduleData> _repeated_scheduleData_codec = FieldCodec.ForMessage<ActivityScheduleData>(18U, ActivityScheduleData.Parser);

		// Token: 0x04001B77 RID: 7031
		private readonly RepeatedField<ActivityScheduleData> scheduleData_ = new RepeatedField<ActivityScheduleData>();
	}
}
