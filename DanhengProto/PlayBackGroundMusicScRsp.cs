using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CAB RID: 3243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayBackGroundMusicScRsp : IMessage<PlayBackGroundMusicScRsp>, IMessage, IEquatable<PlayBackGroundMusicScRsp>, IDeepCloneable<PlayBackGroundMusicScRsp>, IBufferMessage
	{
		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600901B RID: 36891 RVA: 0x0017C8DD File Offset: 0x0017AADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayBackGroundMusicScRsp> Parser
		{
			get
			{
				return PlayBackGroundMusicScRsp._parser;
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600901C RID: 36892 RVA: 0x0017C8E4 File Offset: 0x0017AAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayBackGroundMusicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x0600901D RID: 36893 RVA: 0x0017C8F6 File Offset: 0x0017AAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayBackGroundMusicScRsp.Descriptor;
			}
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x0017C8FD File Offset: 0x0017AAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayBackGroundMusicScRsp()
		{
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x0017C905 File Offset: 0x0017AB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayBackGroundMusicScRsp(PlayBackGroundMusicScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.currentMusicId_ = other.currentMusicId_;
			this.playMusicId_ = other.playMusicId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x0017C942 File Offset: 0x0017AB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayBackGroundMusicScRsp Clone()
		{
			return new PlayBackGroundMusicScRsp(this);
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x06009021 RID: 36897 RVA: 0x0017C94A File Offset: 0x0017AB4A
		// (set) Token: 0x06009022 RID: 36898 RVA: 0x0017C952 File Offset: 0x0017AB52
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

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x06009023 RID: 36899 RVA: 0x0017C95B File Offset: 0x0017AB5B
		// (set) Token: 0x06009024 RID: 36900 RVA: 0x0017C963 File Offset: 0x0017AB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrentMusicId
		{
			get
			{
				return this.currentMusicId_;
			}
			set
			{
				this.currentMusicId_ = value;
			}
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x06009025 RID: 36901 RVA: 0x0017C96C File Offset: 0x0017AB6C
		// (set) Token: 0x06009026 RID: 36902 RVA: 0x0017C974 File Offset: 0x0017AB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlayMusicId
		{
			get
			{
				return this.playMusicId_;
			}
			set
			{
				this.playMusicId_ = value;
			}
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0017C97D File Offset: 0x0017AB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayBackGroundMusicScRsp);
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x0017C98C File Offset: 0x0017AB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayBackGroundMusicScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.CurrentMusicId == other.CurrentMusicId && this.PlayMusicId == other.PlayMusicId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0017C9E8 File Offset: 0x0017ABE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurrentMusicId != 0U)
			{
				num ^= this.CurrentMusicId.GetHashCode();
			}
			if (this.PlayMusicId != 0U)
			{
				num ^= this.PlayMusicId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x0017CA59 File Offset: 0x0017AC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0017CA61 File Offset: 0x0017AC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0017CA6C File Offset: 0x0017AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayMusicId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.PlayMusicId);
			}
			if (this.CurrentMusicId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.CurrentMusicId);
			}
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

		// Token: 0x0600902D RID: 36909 RVA: 0x0017CAE4 File Offset: 0x0017ACE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurrentMusicId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrentMusicId);
			}
			if (this.PlayMusicId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayMusicId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x0017CB54 File Offset: 0x0017AD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayBackGroundMusicScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurrentMusicId != 0U)
			{
				this.CurrentMusicId = other.CurrentMusicId;
			}
			if (other.PlayMusicId != 0U)
			{
				this.PlayMusicId = other.PlayMusicId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600902F RID: 36911 RVA: 0x0017CBB8 File Offset: 0x0017ADB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x0017CBC4 File Offset: 0x0017ADC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 72U)
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
					else
					{
						this.CurrentMusicId = input.ReadUInt32();
					}
				}
				else
				{
					this.PlayMusicId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003763 RID: 14179
		private static readonly MessageParser<PlayBackGroundMusicScRsp> _parser = new MessageParser<PlayBackGroundMusicScRsp>(() => new PlayBackGroundMusicScRsp());

		// Token: 0x04003764 RID: 14180
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003765 RID: 14181
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04003766 RID: 14182
		private uint retcode_;

		// Token: 0x04003767 RID: 14183
		public const int CurrentMusicIdFieldNumber = 9;

		// Token: 0x04003768 RID: 14184
		private uint currentMusicId_;

		// Token: 0x04003769 RID: 14185
		public const int PlayMusicIdFieldNumber = 4;

		// Token: 0x0400376A RID: 14186
		private uint playMusicId_;
	}
}
