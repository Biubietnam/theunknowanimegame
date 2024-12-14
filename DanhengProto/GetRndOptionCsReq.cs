using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200079D RID: 1949
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRndOptionCsReq : IMessage<GetRndOptionCsReq>, IMessage, IEquatable<GetRndOptionCsReq>, IDeepCloneable<GetRndOptionCsReq>, IBufferMessage
	{
		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x000E9788 File Offset: 0x000E7988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRndOptionCsReq> Parser
		{
			get
			{
				return GetRndOptionCsReq._parser;
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06005711 RID: 22289 RVA: 0x000E978F File Offset: 0x000E798F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRndOptionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x000E97A1 File Offset: 0x000E79A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRndOptionCsReq.Descriptor;
			}
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x000E97A8 File Offset: 0x000E79A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRndOptionCsReq()
		{
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x000E97B0 File Offset: 0x000E79B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRndOptionCsReq(GetRndOptionCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x000E97D5 File Offset: 0x000E79D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRndOptionCsReq Clone()
		{
			return new GetRndOptionCsReq(this);
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x000E97DD File Offset: 0x000E79DD
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x000E97E5 File Offset: 0x000E79E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x000E97EE File Offset: 0x000E79EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRndOptionCsReq);
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x000E97FC File Offset: 0x000E79FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRndOptionCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x000E982C File Offset: 0x000E7A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x000E986B File Offset: 0x000E7A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x000E9873 File Offset: 0x000E7A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x000E987C File Offset: 0x000E7A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x000E98B0 File Offset: 0x000E7AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x000E98EE File Offset: 0x000E7AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRndOptionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x000E991F File Offset: 0x000E7B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x000E9928 File Offset: 0x000E7B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002212 RID: 8722
		private static readonly MessageParser<GetRndOptionCsReq> _parser = new MessageParser<GetRndOptionCsReq>(() => new GetRndOptionCsReq());

		// Token: 0x04002213 RID: 8723
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002214 RID: 8724
		public const int IdFieldNumber = 1;

		// Token: 0x04002215 RID: 8725
		private uint id_;
	}
}
