using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001345 RID: 4933
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportToMissionResetPointCsReq : IMessage<TeleportToMissionResetPointCsReq>, IMessage, IEquatable<TeleportToMissionResetPointCsReq>, IDeepCloneable<TeleportToMissionResetPointCsReq>, IBufferMessage
	{
		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x0600DC26 RID: 56358 RVA: 0x0024A3FB File Offset: 0x002485FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportToMissionResetPointCsReq> Parser
		{
			get
			{
				return TeleportToMissionResetPointCsReq._parser;
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0600DC27 RID: 56359 RVA: 0x0024A402 File Offset: 0x00248602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TeleportToMissionResetPointCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x0600DC28 RID: 56360 RVA: 0x0024A414 File Offset: 0x00248614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportToMissionResetPointCsReq.Descriptor;
			}
		}

		// Token: 0x0600DC29 RID: 56361 RVA: 0x0024A41B File Offset: 0x0024861B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToMissionResetPointCsReq()
		{
		}

		// Token: 0x0600DC2A RID: 56362 RVA: 0x0024A423 File Offset: 0x00248623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToMissionResetPointCsReq(TeleportToMissionResetPointCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x0024A43C File Offset: 0x0024863C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportToMissionResetPointCsReq Clone()
		{
			return new TeleportToMissionResetPointCsReq(this);
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x0024A444 File Offset: 0x00248644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportToMissionResetPointCsReq);
		}

		// Token: 0x0600DC2D RID: 56365 RVA: 0x0024A452 File Offset: 0x00248652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportToMissionResetPointCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600DC2E RID: 56366 RVA: 0x0024A470 File Offset: 0x00248670
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

		// Token: 0x0600DC2F RID: 56367 RVA: 0x0024A496 File Offset: 0x00248696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x0024A49E File Offset: 0x0024869E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC31 RID: 56369 RVA: 0x0024A4A7 File Offset: 0x002486A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC32 RID: 56370 RVA: 0x0024A4C0 File Offset: 0x002486C0
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

		// Token: 0x0600DC33 RID: 56371 RVA: 0x0024A4E6 File Offset: 0x002486E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportToMissionResetPointCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC34 RID: 56372 RVA: 0x0024A503 File Offset: 0x00248703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC35 RID: 56373 RVA: 0x0024A50C File Offset: 0x0024870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400579A RID: 22426
		private static readonly MessageParser<TeleportToMissionResetPointCsReq> _parser = new MessageParser<TeleportToMissionResetPointCsReq>(() => new TeleportToMissionResetPointCsReq());

		// Token: 0x0400579B RID: 22427
		private UnknownFieldSet _unknownFields;
	}
}
