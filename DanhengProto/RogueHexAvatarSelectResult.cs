using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EA5 RID: 3749
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueHexAvatarSelectResult : IMessage<RogueHexAvatarSelectResult>, IMessage, IEquatable<RogueHexAvatarSelectResult>, IDeepCloneable<RogueHexAvatarSelectResult>, IBufferMessage
	{
		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0600A77C RID: 42876 RVA: 0x001C3190 File Offset: 0x001C1390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueHexAvatarSelectResult> Parser
		{
			get
			{
				return RogueHexAvatarSelectResult._parser;
			}
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x0600A77D RID: 42877 RVA: 0x001C3197 File Offset: 0x001C1397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueHexAvatarSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0600A77E RID: 42878 RVA: 0x001C31A9 File Offset: 0x001C13A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueHexAvatarSelectResult.Descriptor;
			}
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x001C31B0 File Offset: 0x001C13B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectResult()
		{
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x001C31B8 File Offset: 0x001C13B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectResult(RogueHexAvatarSelectResult other) : this()
		{
			this.miracleSelectId_ = other.miracleSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x001C31DD File Offset: 0x001C13DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectResult Clone()
		{
			return new RogueHexAvatarSelectResult(this);
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0600A782 RID: 42882 RVA: 0x001C31E5 File Offset: 0x001C13E5
		// (set) Token: 0x0600A783 RID: 42883 RVA: 0x001C31ED File Offset: 0x001C13ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleSelectId
		{
			get
			{
				return this.miracleSelectId_;
			}
			set
			{
				this.miracleSelectId_ = value;
			}
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x001C31F6 File Offset: 0x001C13F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueHexAvatarSelectResult);
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x001C3204 File Offset: 0x001C1404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueHexAvatarSelectResult other)
		{
			return other != null && (other == this || (this.MiracleSelectId == other.MiracleSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x001C3234 File Offset: 0x001C1434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MiracleSelectId != 0U)
			{
				num ^= this.MiracleSelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x001C3273 File Offset: 0x001C1473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x001C327B File Offset: 0x001C147B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x001C3284 File Offset: 0x001C1484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MiracleSelectId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MiracleSelectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x001C32B8 File Offset: 0x001C14B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MiracleSelectId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleSelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A78B RID: 42891 RVA: 0x001C32F6 File Offset: 0x001C14F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueHexAvatarSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MiracleSelectId != 0U)
			{
				this.MiracleSelectId = other.MiracleSelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x001C3327 File Offset: 0x001C1527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x001C3330 File Offset: 0x001C1530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MiracleSelectId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400447B RID: 17531
		private static readonly MessageParser<RogueHexAvatarSelectResult> _parser = new MessageParser<RogueHexAvatarSelectResult>(() => new RogueHexAvatarSelectResult());

		// Token: 0x0400447C RID: 17532
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400447D RID: 17533
		public const int MiracleSelectIdFieldNumber = 2;

		// Token: 0x0400447E RID: 17534
		private uint miracleSelectId_;
	}
}
