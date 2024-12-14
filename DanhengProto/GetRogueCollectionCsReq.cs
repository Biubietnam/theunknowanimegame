using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007AD RID: 1965
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueCollectionCsReq : IMessage<GetRogueCollectionCsReq>, IMessage, IEquatable<GetRogueCollectionCsReq>, IDeepCloneable<GetRogueCollectionCsReq>, IBufferMessage
	{
		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x000EACFB File Offset: 0x000E8EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueCollectionCsReq> Parser
		{
			get
			{
				return GetRogueCollectionCsReq._parser;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060057B9 RID: 22457 RVA: 0x000EAD02 File Offset: 0x000E8F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueCollectionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x000EAD14 File Offset: 0x000E8F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueCollectionCsReq.Descriptor;
			}
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x000EAD1B File Offset: 0x000E8F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCollectionCsReq()
		{
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x000EAD23 File Offset: 0x000E8F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCollectionCsReq(GetRogueCollectionCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x000EAD3C File Offset: 0x000E8F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCollectionCsReq Clone()
		{
			return new GetRogueCollectionCsReq(this);
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x000EAD44 File Offset: 0x000E8F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueCollectionCsReq);
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x000EAD52 File Offset: 0x000E8F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueCollectionCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x000EAD70 File Offset: 0x000E8F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x000EAD96 File Offset: 0x000E8F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x000EAD9E File Offset: 0x000E8F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x000EADA7 File Offset: 0x000E8FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x000EADC0 File Offset: 0x000E8FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x000EADE6 File Offset: 0x000E8FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueCollectionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x000EAE03 File Offset: 0x000E9003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x000EAE0C File Offset: 0x000E900C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400223E RID: 8766
		private static readonly MessageParser<GetRogueCollectionCsReq> _parser = new MessageParser<GetRogueCollectionCsReq>(() => new GetRogueCollectionCsReq());

		// Token: 0x0400223F RID: 8767
		private UnknownFieldSet _unknownFields;
	}
}
