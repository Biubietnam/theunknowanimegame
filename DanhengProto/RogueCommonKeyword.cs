using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E57 RID: 3671
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonKeyword : IMessage<RogueCommonKeyword>, IMessage, IEquatable<RogueCommonKeyword>, IDeepCloneable<RogueCommonKeyword>, IBufferMessage
	{
		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x001B86EC File Offset: 0x001B68EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonKeyword> Parser
		{
			get
			{
				return RogueCommonKeyword._parser;
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600A3C2 RID: 41922 RVA: 0x001B86F3 File Offset: 0x001B68F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonKeywordReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600A3C3 RID: 41923 RVA: 0x001B8705 File Offset: 0x001B6905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonKeyword.Descriptor;
			}
		}

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x001B870C File Offset: 0x001B690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonKeyword()
		{
		}

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x001B8714 File Offset: 0x001B6914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonKeyword(RogueCommonKeyword other) : this()
		{
			this.keywordId_ = other.keywordId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x001B8739 File Offset: 0x001B6939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonKeyword Clone()
		{
			return new RogueCommonKeyword(this);
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x001B8741 File Offset: 0x001B6941
		// (set) Token: 0x0600A3C8 RID: 41928 RVA: 0x001B8749 File Offset: 0x001B6949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KeywordId
		{
			get
			{
				return this.keywordId_;
			}
			set
			{
				this.keywordId_ = value;
			}
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x001B8752 File Offset: 0x001B6952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonKeyword);
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x001B8760 File Offset: 0x001B6960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonKeyword other)
		{
			return other != null && (other == this || (this.KeywordId == other.KeywordId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3CB RID: 41931 RVA: 0x001B8790 File Offset: 0x001B6990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KeywordId != 0U)
			{
				num ^= this.KeywordId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x001B87CF File Offset: 0x001B69CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x001B87D7 File Offset: 0x001B69D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x001B87E0 File Offset: 0x001B69E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KeywordId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.KeywordId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x001B8814 File Offset: 0x001B6A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KeywordId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KeywordId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x001B8852 File Offset: 0x001B6A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonKeyword other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KeywordId != 0U)
			{
				this.KeywordId = other.KeywordId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x001B8883 File Offset: 0x001B6A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x001B888C File Offset: 0x001B6A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.KeywordId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004303 RID: 17155
		private static readonly MessageParser<RogueCommonKeyword> _parser = new MessageParser<RogueCommonKeyword>(() => new RogueCommonKeyword());

		// Token: 0x04004304 RID: 17156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004305 RID: 17157
		public const int KeywordIdFieldNumber = 15;

		// Token: 0x04004306 RID: 17158
		private uint keywordId_;
	}
}
