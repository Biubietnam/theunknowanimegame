using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200039B RID: 923
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DifficultyAdjustmentGetDataCsReq : IMessage<DifficultyAdjustmentGetDataCsReq>, IMessage, IEquatable<DifficultyAdjustmentGetDataCsReq>, IDeepCloneable<DifficultyAdjustmentGetDataCsReq>, IBufferMessage
	{
		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x0007249B File Offset: 0x0007069B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DifficultyAdjustmentGetDataCsReq> Parser
		{
			get
			{
				return DifficultyAdjustmentGetDataCsReq._parser;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x000724A2 File Offset: 0x000706A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DifficultyAdjustmentGetDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x000724B4 File Offset: 0x000706B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DifficultyAdjustmentGetDataCsReq.Descriptor;
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000724BB File Offset: 0x000706BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentGetDataCsReq()
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000724C3 File Offset: 0x000706C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentGetDataCsReq(DifficultyAdjustmentGetDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000724DC File Offset: 0x000706DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentGetDataCsReq Clone()
		{
			return new DifficultyAdjustmentGetDataCsReq(this);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000724E4 File Offset: 0x000706E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DifficultyAdjustmentGetDataCsReq);
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000724F2 File Offset: 0x000706F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DifficultyAdjustmentGetDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00072510 File Offset: 0x00070710
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

		// Token: 0x06002919 RID: 10521 RVA: 0x00072536 File Offset: 0x00070736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0007253E File Offset: 0x0007073E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00072547 File Offset: 0x00070747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00072560 File Offset: 0x00070760
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

		// Token: 0x0600291D RID: 10525 RVA: 0x00072586 File Offset: 0x00070786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DifficultyAdjustmentGetDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000725A3 File Offset: 0x000707A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000725AC File Offset: 0x000707AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001094 RID: 4244
		private static readonly MessageParser<DifficultyAdjustmentGetDataCsReq> _parser = new MessageParser<DifficultyAdjustmentGetDataCsReq>(() => new DifficultyAdjustmentGetDataCsReq());

		// Token: 0x04001095 RID: 4245
		private UnknownFieldSet _unknownFields;
	}
}
