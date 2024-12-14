using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000695 RID: 1685
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFantasticStoryActivityDataCsReq : IMessage<GetFantasticStoryActivityDataCsReq>, IMessage, IEquatable<GetFantasticStoryActivityDataCsReq>, IDeepCloneable<GetFantasticStoryActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x000CD259 File Offset: 0x000CB459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFantasticStoryActivityDataCsReq> Parser
		{
			get
			{
				return GetFantasticStoryActivityDataCsReq._parser;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06004B79 RID: 19321 RVA: 0x000CD260 File Offset: 0x000CB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFantasticStoryActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x000CD272 File Offset: 0x000CB472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFantasticStoryActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x000CD279 File Offset: 0x000CB479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFantasticStoryActivityDataCsReq()
		{
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x000CD281 File Offset: 0x000CB481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFantasticStoryActivityDataCsReq(GetFantasticStoryActivityDataCsReq other) : this()
		{
			this.kLANEABKELD_ = other.kLANEABKELD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x000CD2A6 File Offset: 0x000CB4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFantasticStoryActivityDataCsReq Clone()
		{
			return new GetFantasticStoryActivityDataCsReq(this);
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x000CD2AE File Offset: 0x000CB4AE
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x000CD2B6 File Offset: 0x000CB4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KLANEABKELD
		{
			get
			{
				return this.kLANEABKELD_;
			}
			set
			{
				this.kLANEABKELD_ = value;
			}
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x000CD2BF File Offset: 0x000CB4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFantasticStoryActivityDataCsReq);
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x000CD2CD File Offset: 0x000CB4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFantasticStoryActivityDataCsReq other)
		{
			return other != null && (other == this || (this.KLANEABKELD == other.KLANEABKELD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x000CD2FC File Offset: 0x000CB4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KLANEABKELD != 0U)
			{
				num ^= this.KLANEABKELD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x000CD33B File Offset: 0x000CB53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x000CD343 File Offset: 0x000CB543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x000CD34C File Offset: 0x000CB54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KLANEABKELD != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.KLANEABKELD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x000CD380 File Offset: 0x000CB580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KLANEABKELD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KLANEABKELD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x000CD3BE File Offset: 0x000CB5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFantasticStoryActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KLANEABKELD != 0U)
			{
				this.KLANEABKELD = other.KLANEABKELD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x000CD3EF File Offset: 0x000CB5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x000CD3F8 File Offset: 0x000CB5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.KLANEABKELD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001DEE RID: 7662
		private static readonly MessageParser<GetFantasticStoryActivityDataCsReq> _parser = new MessageParser<GetFantasticStoryActivityDataCsReq>(() => new GetFantasticStoryActivityDataCsReq());

		// Token: 0x04001DEF RID: 7663
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DF0 RID: 7664
		public const int KLANEABKELDFieldNumber = 7;

		// Token: 0x04001DF1 RID: 7665
		private uint kLANEABKELD_;
	}
}
