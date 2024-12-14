using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF9 RID: 4089
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournQueryCsReq : IMessage<RogueTournQueryCsReq>, IMessage, IEquatable<RogueTournQueryCsReq>, IDeepCloneable<RogueTournQueryCsReq>, IBufferMessage
	{
		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x001E8627 File Offset: 0x001E6827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournQueryCsReq> Parser
		{
			get
			{
				return RogueTournQueryCsReq._parser;
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600B5F3 RID: 46579 RVA: 0x001E862E File Offset: 0x001E682E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournQueryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600B5F4 RID: 46580 RVA: 0x001E8640 File Offset: 0x001E6840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournQueryCsReq.Descriptor;
			}
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x001E8647 File Offset: 0x001E6847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournQueryCsReq()
		{
		}

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x001E864F File Offset: 0x001E684F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournQueryCsReq(RogueTournQueryCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x001E8668 File Offset: 0x001E6868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournQueryCsReq Clone()
		{
			return new RogueTournQueryCsReq(this);
		}

		// Token: 0x0600B5F8 RID: 46584 RVA: 0x001E8670 File Offset: 0x001E6870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournQueryCsReq);
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x001E867E File Offset: 0x001E687E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournQueryCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x001E869C File Offset: 0x001E689C
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

		// Token: 0x0600B5FB RID: 46587 RVA: 0x001E86C2 File Offset: 0x001E68C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B5FC RID: 46588 RVA: 0x001E86CA File Offset: 0x001E68CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x001E86D3 File Offset: 0x001E68D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x001E86EC File Offset: 0x001E68EC
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

		// Token: 0x0600B5FF RID: 46591 RVA: 0x001E8712 File Offset: 0x001E6912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournQueryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B600 RID: 46592 RVA: 0x001E872F File Offset: 0x001E692F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B601 RID: 46593 RVA: 0x001E8738 File Offset: 0x001E6938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040049CA RID: 18890
		private static readonly MessageParser<RogueTournQueryCsReq> _parser = new MessageParser<RogueTournQueryCsReq>(() => new RogueTournQueryCsReq());

		// Token: 0x040049CB RID: 18891
		private UnknownFieldSet _unknownFields;
	}
}
