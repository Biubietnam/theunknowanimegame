using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D55 RID: 3413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitTrackPhotoStageScRsp : IMessage<QuitTrackPhotoStageScRsp>, IMessage, IEquatable<QuitTrackPhotoStageScRsp>, IDeepCloneable<QuitTrackPhotoStageScRsp>, IBufferMessage
	{
		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x06009883 RID: 39043 RVA: 0x001964FC File Offset: 0x001946FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitTrackPhotoStageScRsp> Parser
		{
			get
			{
				return QuitTrackPhotoStageScRsp._parser;
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x06009884 RID: 39044 RVA: 0x00196503 File Offset: 0x00194703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitTrackPhotoStageScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x06009885 RID: 39045 RVA: 0x00196515 File Offset: 0x00194715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitTrackPhotoStageScRsp.Descriptor;
			}
		}

		// Token: 0x06009886 RID: 39046 RVA: 0x0019651C File Offset: 0x0019471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTrackPhotoStageScRsp()
		{
		}

		// Token: 0x06009887 RID: 39047 RVA: 0x00196524 File Offset: 0x00194724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTrackPhotoStageScRsp(QuitTrackPhotoStageScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009888 RID: 39048 RVA: 0x00196549 File Offset: 0x00194749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitTrackPhotoStageScRsp Clone()
		{
			return new QuitTrackPhotoStageScRsp(this);
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x06009889 RID: 39049 RVA: 0x00196551 File Offset: 0x00194751
		// (set) Token: 0x0600988A RID: 39050 RVA: 0x00196559 File Offset: 0x00194759
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

		// Token: 0x0600988B RID: 39051 RVA: 0x00196562 File Offset: 0x00194762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitTrackPhotoStageScRsp);
		}

		// Token: 0x0600988C RID: 39052 RVA: 0x00196570 File Offset: 0x00194770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitTrackPhotoStageScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600988D RID: 39053 RVA: 0x001965A0 File Offset: 0x001947A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600988E RID: 39054 RVA: 0x001965DF File Offset: 0x001947DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600988F RID: 39055 RVA: 0x001965E7 File Offset: 0x001947E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009890 RID: 39056 RVA: 0x001965F0 File Offset: 0x001947F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009891 RID: 39057 RVA: 0x00196624 File Offset: 0x00194824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06009892 RID: 39058 RVA: 0x00196662 File Offset: 0x00194862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitTrackPhotoStageScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009893 RID: 39059 RVA: 0x00196693 File Offset: 0x00194893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009894 RID: 39060 RVA: 0x0019669C File Offset: 0x0019489C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B48 RID: 15176
		private static readonly MessageParser<QuitTrackPhotoStageScRsp> _parser = new MessageParser<QuitTrackPhotoStageScRsp>(() => new QuitTrackPhotoStageScRsp());

		// Token: 0x04003B49 RID: 15177
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B4A RID: 15178
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04003B4B RID: 15179
		private uint retcode_;
	}
}
