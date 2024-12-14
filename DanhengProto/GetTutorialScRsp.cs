using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200083F RID: 2111
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTutorialScRsp : IMessage<GetTutorialScRsp>, IMessage, IEquatable<GetTutorialScRsp>, IDeepCloneable<GetTutorialScRsp>, IBufferMessage
	{
		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06005DE5 RID: 24037 RVA: 0x000F8D4D File Offset: 0x000F6F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTutorialScRsp> Parser
		{
			get
			{
				return GetTutorialScRsp._parser;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06005DE6 RID: 24038 RVA: 0x000F8D54 File Offset: 0x000F6F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTutorialScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x000F8D66 File Offset: 0x000F6F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTutorialScRsp.Descriptor;
			}
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x000F8D6D File Offset: 0x000F6F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialScRsp()
		{
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x000F8D80 File Offset: 0x000F6F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialScRsp(GetTutorialScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.tutorialList_ = other.tutorialList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x000F8DB6 File Offset: 0x000F6FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialScRsp Clone()
		{
			return new GetTutorialScRsp(this);
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x000F8DBE File Offset: 0x000F6FBE
		// (set) Token: 0x06005DEC RID: 24044 RVA: 0x000F8DC6 File Offset: 0x000F6FC6
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

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06005DED RID: 24045 RVA: 0x000F8DCF File Offset: 0x000F6FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Tutorial> TutorialList
		{
			get
			{
				return this.tutorialList_;
			}
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x000F8DD7 File Offset: 0x000F6FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTutorialScRsp);
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x000F8DE8 File Offset: 0x000F6FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTutorialScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.tutorialList_.Equals(other.tutorialList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x000F8E38 File Offset: 0x000F7038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.tutorialList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x000F8E85 File Offset: 0x000F7085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x000F8E8D File Offset: 0x000F708D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x000F8E98 File Offset: 0x000F7098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.tutorialList_.WriteTo(ref output, GetTutorialScRsp._repeated_tutorialList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x000F8EE8 File Offset: 0x000F70E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.tutorialList_.CalculateSize(GetTutorialScRsp._repeated_tutorialList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x000F8F3C File Offset: 0x000F713C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTutorialScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.tutorialList_.Add(other.tutorialList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x000F8F89 File Offset: 0x000F7189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x000F8F94 File Offset: 0x000F7194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tutorialList_.AddEntriesFrom(ref input, GetTutorialScRsp._repeated_tutorialList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002434 RID: 9268
		private static readonly MessageParser<GetTutorialScRsp> _parser = new MessageParser<GetTutorialScRsp>(() => new GetTutorialScRsp());

		// Token: 0x04002435 RID: 9269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002436 RID: 9270
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04002437 RID: 9271
		private uint retcode_;

		// Token: 0x04002438 RID: 9272
		public const int TutorialListFieldNumber = 9;

		// Token: 0x04002439 RID: 9273
		private static readonly FieldCodec<Tutorial> _repeated_tutorialList_codec = FieldCodec.ForMessage<Tutorial>(74U, Tutorial.Parser);

		// Token: 0x0400243A RID: 9274
		private readonly RepeatedField<Tutorial> tutorialList_ = new RepeatedField<Tutorial>();
	}
}
