using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E1B RID: 3611
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBuffEnhanceInfoList : IMessage<RogueBuffEnhanceInfoList>, IMessage, IEquatable<RogueBuffEnhanceInfoList>, IDeepCloneable<RogueBuffEnhanceInfoList>, IBufferMessage
	{
		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600A148 RID: 41288 RVA: 0x001B0749 File Offset: 0x001AE949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBuffEnhanceInfoList> Parser
		{
			get
			{
				return RogueBuffEnhanceInfoList._parser;
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x001B0750 File Offset: 0x001AE950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBuffEnhanceInfoListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x0600A14A RID: 41290 RVA: 0x001B0762 File Offset: 0x001AE962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBuffEnhanceInfoList.Descriptor;
			}
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x001B0769 File Offset: 0x001AE969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffEnhanceInfoList()
		{
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x001B077C File Offset: 0x001AE97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffEnhanceInfoList(RogueBuffEnhanceInfoList other) : this()
		{
			this.enhanceInfoList_ = other.enhanceInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x001B07A6 File Offset: 0x001AE9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBuffEnhanceInfoList Clone()
		{
			return new RogueBuffEnhanceInfoList(this);
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600A14E RID: 41294 RVA: 0x001B07AE File Offset: 0x001AE9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueBuffEnhanceInfo> EnhanceInfoList
		{
			get
			{
				return this.enhanceInfoList_;
			}
		}

		// Token: 0x0600A14F RID: 41295 RVA: 0x001B07B6 File Offset: 0x001AE9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBuffEnhanceInfoList);
		}

		// Token: 0x0600A150 RID: 41296 RVA: 0x001B07C4 File Offset: 0x001AE9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBuffEnhanceInfoList other)
		{
			return other != null && (other == this || (this.enhanceInfoList_.Equals(other.enhanceInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x001B07F8 File Offset: 0x001AE9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.enhanceInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x001B082C File Offset: 0x001AEA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x001B0834 File Offset: 0x001AEA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x001B083D File Offset: 0x001AEA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enhanceInfoList_.WriteTo(ref output, RogueBuffEnhanceInfoList._repeated_enhanceInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x001B0864 File Offset: 0x001AEA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.enhanceInfoList_.CalculateSize(RogueBuffEnhanceInfoList._repeated_enhanceInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x001B089D File Offset: 0x001AEA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBuffEnhanceInfoList other)
		{
			if (other == null)
			{
				return;
			}
			this.enhanceInfoList_.Add(other.enhanceInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A157 RID: 41303 RVA: 0x001B08CB File Offset: 0x001AEACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x001B08D4 File Offset: 0x001AEAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.enhanceInfoList_.AddEntriesFrom(ref input, RogueBuffEnhanceInfoList._repeated_enhanceInfoList_codec);
				}
			}
		}

		// Token: 0x04004206 RID: 16902
		private static readonly MessageParser<RogueBuffEnhanceInfoList> _parser = new MessageParser<RogueBuffEnhanceInfoList>(() => new RogueBuffEnhanceInfoList());

		// Token: 0x04004207 RID: 16903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004208 RID: 16904
		public const int EnhanceInfoListFieldNumber = 6;

		// Token: 0x04004209 RID: 16905
		private static readonly FieldCodec<RogueBuffEnhanceInfo> _repeated_enhanceInfoList_codec = FieldCodec.ForMessage<RogueBuffEnhanceInfo>(50U, RogueBuffEnhanceInfo.Parser);

		// Token: 0x0400420A RID: 16906
		private readonly RepeatedField<RogueBuffEnhanceInfo> enhanceInfoList_ = new RepeatedField<RogueBuffEnhanceInfo>();
	}
}
