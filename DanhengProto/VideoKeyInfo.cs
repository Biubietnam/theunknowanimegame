using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001413 RID: 5139
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class VideoKeyInfo : IMessage<VideoKeyInfo>, IMessage, IEquatable<VideoKeyInfo>, IDeepCloneable<VideoKeyInfo>, IBufferMessage
	{
		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x0600E542 RID: 58690 RVA: 0x00261A54 File Offset: 0x0025FC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VideoKeyInfo> Parser
		{
			get
			{
				return VideoKeyInfo._parser;
			}
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x0600E543 RID: 58691 RVA: 0x00261A5B File Offset: 0x0025FC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VideoKeyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x0600E544 RID: 58692 RVA: 0x00261A6D File Offset: 0x0025FC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VideoKeyInfo.Descriptor;
			}
		}

		// Token: 0x0600E545 RID: 58693 RVA: 0x00261A74 File Offset: 0x0025FC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VideoKeyInfo()
		{
		}

		// Token: 0x0600E546 RID: 58694 RVA: 0x00261A7C File Offset: 0x0025FC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VideoKeyInfo(VideoKeyInfo other) : this()
		{
			this.id_ = other.id_;
			this.videoKey_ = other.videoKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E547 RID: 58695 RVA: 0x00261AAD File Offset: 0x0025FCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VideoKeyInfo Clone()
		{
			return new VideoKeyInfo(this);
		}

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x0600E548 RID: 58696 RVA: 0x00261AB5 File Offset: 0x0025FCB5
		// (set) Token: 0x0600E549 RID: 58697 RVA: 0x00261ABD File Offset: 0x0025FCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x0600E54A RID: 58698 RVA: 0x00261AC6 File Offset: 0x0025FCC6
		// (set) Token: 0x0600E54B RID: 58699 RVA: 0x00261ACE File Offset: 0x0025FCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong VideoKey
		{
			get
			{
				return this.videoKey_;
			}
			set
			{
				this.videoKey_ = value;
			}
		}

		// Token: 0x0600E54C RID: 58700 RVA: 0x00261AD7 File Offset: 0x0025FCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VideoKeyInfo);
		}

		// Token: 0x0600E54D RID: 58701 RVA: 0x00261AE5 File Offset: 0x0025FCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VideoKeyInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.VideoKey == other.VideoKey && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E54E RID: 58702 RVA: 0x00261B24 File Offset: 0x0025FD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.VideoKey != 0UL)
			{
				num ^= this.VideoKey.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E54F RID: 58703 RVA: 0x00261B7C File Offset: 0x0025FD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E550 RID: 58704 RVA: 0x00261B84 File Offset: 0x0025FD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E551 RID: 58705 RVA: 0x00261B90 File Offset: 0x0025FD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VideoKey != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.VideoKey);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E552 RID: 58706 RVA: 0x00261BEC File Offset: 0x0025FDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.VideoKey != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.VideoKey);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E553 RID: 58707 RVA: 0x00261C44 File Offset: 0x0025FE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VideoKeyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.VideoKey != 0UL)
			{
				this.VideoKey = other.VideoKey;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E554 RID: 58708 RVA: 0x00261C94 File Offset: 0x0025FE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x00261CA0 File Offset: 0x0025FEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.VideoKey = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04005B10 RID: 23312
		private static readonly MessageParser<VideoKeyInfo> _parser = new MessageParser<VideoKeyInfo>(() => new VideoKeyInfo());

		// Token: 0x04005B11 RID: 23313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B12 RID: 23314
		public const int IdFieldNumber = 8;

		// Token: 0x04005B13 RID: 23315
		private uint id_;

		// Token: 0x04005B14 RID: 23316
		public const int VideoKeyFieldNumber = 6;

		// Token: 0x04005B15 RID: 23317
		private ulong videoKey_;
	}
}
