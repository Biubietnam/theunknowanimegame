using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D53 RID: 3411
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitTrackPhotoStageCsReq : IMessage<QuitTrackPhotoStageCsReq>, IMessage, IEquatable<QuitTrackPhotoStageCsReq>, IDeepCloneable<QuitTrackPhotoStageCsReq>, IBufferMessage
	{
		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0600986E RID: 39022 RVA: 0x0019628C File Offset: 0x0019448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitTrackPhotoStageCsReq> Parser
		{
			get
			{
				return QuitTrackPhotoStageCsReq._parser;
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0600986F RID: 39023 RVA: 0x00196293 File Offset: 0x00194493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitTrackPhotoStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x06009870 RID: 39024 RVA: 0x001962A5 File Offset: 0x001944A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitTrackPhotoStageCsReq.Descriptor;
			}
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x001962AC File Offset: 0x001944AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTrackPhotoStageCsReq()
		{
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x001962B4 File Offset: 0x001944B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTrackPhotoStageCsReq(QuitTrackPhotoStageCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x001962D9 File Offset: 0x001944D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTrackPhotoStageCsReq Clone()
		{
			return new QuitTrackPhotoStageCsReq(this);
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x06009874 RID: 39028 RVA: 0x001962E1 File Offset: 0x001944E1
		// (set) Token: 0x06009875 RID: 39029 RVA: 0x001962E9 File Offset: 0x001944E9
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

		// Token: 0x06009876 RID: 39030 RVA: 0x001962F2 File Offset: 0x001944F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitTrackPhotoStageCsReq);
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x00196300 File Offset: 0x00194500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitTrackPhotoStageCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x00196330 File Offset: 0x00194530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06009879 RID: 39033 RVA: 0x0019636F File Offset: 0x0019456F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x00196377 File Offset: 0x00194577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x00196380 File Offset: 0x00194580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.StageId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x001963B4 File Offset: 0x001945B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600987D RID: 39037 RVA: 0x001963F2 File Offset: 0x001945F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitTrackPhotoStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x00196423 File Offset: 0x00194623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x0019642C File Offset: 0x0019462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B43 RID: 15171
		private static readonly MessageParser<QuitTrackPhotoStageCsReq> _parser = new MessageParser<QuitTrackPhotoStageCsReq>(() => new QuitTrackPhotoStageCsReq());

		// Token: 0x04003B44 RID: 15172
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B45 RID: 15173
		public const int StageIdFieldNumber = 5;

		// Token: 0x04003B46 RID: 15174
		private uint stageId_;
	}
}
