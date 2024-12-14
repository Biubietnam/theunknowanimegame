using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB1 RID: 3505
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveRotaterCsReq : IMessage<RemoveRotaterCsReq>, IMessage, IEquatable<RemoveRotaterCsReq>, IDeepCloneable<RemoveRotaterCsReq>, IBufferMessage
	{
		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x06009CB7 RID: 40119 RVA: 0x001A18E1 File Offset: 0x0019FAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveRotaterCsReq> Parser
		{
			get
			{
				return RemoveRotaterCsReq._parser;
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x06009CB8 RID: 40120 RVA: 0x001A18E8 File Offset: 0x0019FAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RemoveRotaterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x06009CB9 RID: 40121 RVA: 0x001A18FA File Offset: 0x0019FAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveRotaterCsReq.Descriptor;
			}
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x001A1901 File Offset: 0x0019FB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveRotaterCsReq()
		{
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x001A1909 File Offset: 0x0019FB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveRotaterCsReq(RemoveRotaterCsReq other) : this()
		{
			this.rotaterData_ = ((other.rotaterData_ != null) ? other.rotaterData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x001A193E File Offset: 0x0019FB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveRotaterCsReq Clone()
		{
			return new RemoveRotaterCsReq(this);
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x06009CBD RID: 40125 RVA: 0x001A1946 File Offset: 0x0019FB46
		// (set) Token: 0x06009CBE RID: 40126 RVA: 0x001A194E File Offset: 0x0019FB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterData RotaterData
		{
			get
			{
				return this.rotaterData_;
			}
			set
			{
				this.rotaterData_ = value;
			}
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x001A1957 File Offset: 0x0019FB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveRotaterCsReq);
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x001A1965 File Offset: 0x0019FB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveRotaterCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.RotaterData, other.RotaterData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x001A1998 File Offset: 0x0019FB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rotaterData_ != null)
			{
				num ^= this.RotaterData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x001A19D4 File Offset: 0x0019FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x001A19DC File Offset: 0x0019FBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x001A19E5 File Offset: 0x0019FBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotaterData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RotaterData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CC5 RID: 40133 RVA: 0x001A1A18 File Offset: 0x0019FC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rotaterData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotaterData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x001A1A58 File Offset: 0x0019FC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveRotaterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rotaterData_ != null)
			{
				if (this.rotaterData_ == null)
				{
					this.RotaterData = new RotaterData();
				}
				this.RotaterData.MergeFrom(other.RotaterData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x001A1AAC File Offset: 0x0019FCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x001A1AB8 File Offset: 0x0019FCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rotaterData_ == null)
					{
						this.RotaterData = new RotaterData();
					}
					input.ReadMessage(this.RotaterData);
				}
			}
		}

		// Token: 0x04003CF3 RID: 15603
		private static readonly MessageParser<RemoveRotaterCsReq> _parser = new MessageParser<RemoveRotaterCsReq>(() => new RemoveRotaterCsReq());

		// Token: 0x04003CF4 RID: 15604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CF5 RID: 15605
		public const int RotaterDataFieldNumber = 2;

		// Token: 0x04003CF6 RID: 15606
		private RotaterData rotaterData_;
	}
}
