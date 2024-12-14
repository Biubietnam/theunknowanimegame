using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FE3 RID: 4067
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLeaveCsReq : IMessage<RogueTournLeaveCsReq>, IMessage, IEquatable<RogueTournLeaveCsReq>, IDeepCloneable<RogueTournLeaveCsReq>, IBufferMessage
	{
		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600B50A RID: 46346 RVA: 0x001E618F File Offset: 0x001E438F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLeaveCsReq> Parser
		{
			get
			{
				return RogueTournLeaveCsReq._parser;
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600B50B RID: 46347 RVA: 0x001E6196 File Offset: 0x001E4396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLeaveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600B50C RID: 46348 RVA: 0x001E61A8 File Offset: 0x001E43A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLeaveCsReq.Descriptor;
			}
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x001E61AF File Offset: 0x001E43AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveCsReq()
		{
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x001E61B7 File Offset: 0x001E43B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveCsReq(RogueTournLeaveCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x001E61D0 File Offset: 0x001E43D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveCsReq Clone()
		{
			return new RogueTournLeaveCsReq(this);
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x001E61D8 File Offset: 0x001E43D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLeaveCsReq);
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x001E61E6 File Offset: 0x001E43E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLeaveCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x001E6204 File Offset: 0x001E4404
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

		// Token: 0x0600B513 RID: 46355 RVA: 0x001E622A File Offset: 0x001E442A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x001E6232 File Offset: 0x001E4432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x001E623B File Offset: 0x001E443B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x001E6254 File Offset: 0x001E4454
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

		// Token: 0x0600B517 RID: 46359 RVA: 0x001E627A File Offset: 0x001E447A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLeaveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x001E6297 File Offset: 0x001E4497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x001E62A0 File Offset: 0x001E44A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004976 RID: 18806
		private static readonly MessageParser<RogueTournLeaveCsReq> _parser = new MessageParser<RogueTournLeaveCsReq>(() => new RogueTournLeaveCsReq());

		// Token: 0x04004977 RID: 18807
		private UnknownFieldSet _unknownFields;
	}
}
