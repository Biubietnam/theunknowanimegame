using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200115F RID: 4447
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooDataCsReq : IMessage<SpaceZooDataCsReq>, IMessage, IEquatable<SpaceZooDataCsReq>, IDeepCloneable<SpaceZooDataCsReq>, IBufferMessage
	{
		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600C667 RID: 50791 RVA: 0x0021490A File Offset: 0x00212B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooDataCsReq> Parser
		{
			get
			{
				return SpaceZooDataCsReq._parser;
			}
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x0600C668 RID: 50792 RVA: 0x00214911 File Offset: 0x00212B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x0600C669 RID: 50793 RVA: 0x00214923 File Offset: 0x00212B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600C66A RID: 50794 RVA: 0x0021492A File Offset: 0x00212B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDataCsReq()
		{
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x00214932 File Offset: 0x00212B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDataCsReq(SpaceZooDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x0021494B File Offset: 0x00212B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooDataCsReq Clone()
		{
			return new SpaceZooDataCsReq(this);
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x00214953 File Offset: 0x00212B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooDataCsReq);
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x00214961 File Offset: 0x00212B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x00214980 File Offset: 0x00212B80
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

		// Token: 0x0600C670 RID: 50800 RVA: 0x002149A6 File Offset: 0x00212BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x002149AE File Offset: 0x00212BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x002149B7 File Offset: 0x00212BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x002149D0 File Offset: 0x00212BD0
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

		// Token: 0x0600C674 RID: 50804 RVA: 0x002149F6 File Offset: 0x00212BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x00214A13 File Offset: 0x00212C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C676 RID: 50806 RVA: 0x00214A1C File Offset: 0x00212C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005027 RID: 20519
		private static readonly MessageParser<SpaceZooDataCsReq> _parser = new MessageParser<SpaceZooDataCsReq>(() => new SpaceZooDataCsReq());

		// Token: 0x04005028 RID: 20520
		private UnknownFieldSet _unknownFields;
	}
}
