using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200083D RID: 2109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTutorialGuideScRsp : IMessage<GetTutorialGuideScRsp>, IMessage, IEquatable<GetTutorialGuideScRsp>, IDeepCloneable<GetTutorialGuideScRsp>, IBufferMessage
	{
		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06005DCF RID: 24015 RVA: 0x000F89F9 File Offset: 0x000F6BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTutorialGuideScRsp> Parser
		{
			get
			{
				return GetTutorialGuideScRsp._parser;
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06005DD0 RID: 24016 RVA: 0x000F8A00 File Offset: 0x000F6C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTutorialGuideScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06005DD1 RID: 24017 RVA: 0x000F8A12 File Offset: 0x000F6C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTutorialGuideScRsp.Descriptor;
			}
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x000F8A19 File Offset: 0x000F6C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialGuideScRsp()
		{
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x000F8A2C File Offset: 0x000F6C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialGuideScRsp(GetTutorialGuideScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.tutorialGuideList_ = other.tutorialGuideList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x000F8A62 File Offset: 0x000F6C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialGuideScRsp Clone()
		{
			return new GetTutorialGuideScRsp(this);
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06005DD5 RID: 24021 RVA: 0x000F8A6A File Offset: 0x000F6C6A
		// (set) Token: 0x06005DD6 RID: 24022 RVA: 0x000F8A72 File Offset: 0x000F6C72
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

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06005DD7 RID: 24023 RVA: 0x000F8A7B File Offset: 0x000F6C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TutorialGuide> TutorialGuideList
		{
			get
			{
				return this.tutorialGuideList_;
			}
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x000F8A83 File Offset: 0x000F6C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTutorialGuideScRsp);
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x000F8A94 File Offset: 0x000F6C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTutorialGuideScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.tutorialGuideList_.Equals(other.tutorialGuideList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x000F8AE4 File Offset: 0x000F6CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.tutorialGuideList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x000F8B31 File Offset: 0x000F6D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x000F8B39 File Offset: 0x000F6D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x000F8B44 File Offset: 0x000F6D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.tutorialGuideList_.WriteTo(ref output, GetTutorialGuideScRsp._repeated_tutorialGuideList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x000F8B94 File Offset: 0x000F6D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.tutorialGuideList_.CalculateSize(GetTutorialGuideScRsp._repeated_tutorialGuideList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x000F8BE8 File Offset: 0x000F6DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTutorialGuideScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.tutorialGuideList_.Add(other.tutorialGuideList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x000F8C35 File Offset: 0x000F6E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x000F8C40 File Offset: 0x000F6E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tutorialGuideList_.AddEntriesFrom(ref input, GetTutorialGuideScRsp._repeated_tutorialGuideList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400242C RID: 9260
		private static readonly MessageParser<GetTutorialGuideScRsp> _parser = new MessageParser<GetTutorialGuideScRsp>(() => new GetTutorialGuideScRsp());

		// Token: 0x0400242D RID: 9261
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400242E RID: 9262
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400242F RID: 9263
		private uint retcode_;

		// Token: 0x04002430 RID: 9264
		public const int TutorialGuideListFieldNumber = 2;

		// Token: 0x04002431 RID: 9265
		private static readonly FieldCodec<TutorialGuide> _repeated_tutorialGuideList_codec = FieldCodec.ForMessage<TutorialGuide>(18U, TutorialGuide.Parser);

		// Token: 0x04002432 RID: 9266
		private readonly RepeatedField<TutorialGuide> tutorialGuideList_ = new RepeatedField<TutorialGuide>();
	}
}
