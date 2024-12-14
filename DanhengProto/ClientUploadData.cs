using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002E5 RID: 741
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientUploadData : IMessage<ClientUploadData>, IMessage, IEquatable<ClientUploadData>, IDeepCloneable<ClientUploadData>, IBufferMessage
	{
		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0005DF98 File Offset: 0x0005C198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientUploadData> Parser
		{
			get
			{
				return ClientUploadData._parser;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0005DF9F File Offset: 0x0005C19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientUploadDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x0005DFB1 File Offset: 0x0005C1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientUploadData.Descriptor;
			}
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x0005DFB8 File Offset: 0x0005C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientUploadData()
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x0005DFD6 File Offset: 0x0005C1D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientUploadData(ClientUploadData other) : this()
		{
			this.cIAFHFEFKOK_ = other.cIAFHFEFKOK_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0005E007 File Offset: 0x0005C207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientUploadData Clone()
		{
			return new ClientUploadData(this);
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0005E00F File Offset: 0x0005C20F
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x0005E017 File Offset: 0x0005C217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CIAFHFEFKOK
		{
			get
			{
				return this.cIAFHFEFKOK_;
			}
			set
			{
				this.cIAFHFEFKOK_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0005E02A File Offset: 0x0005C22A
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x0005E032 File Offset: 0x0005C232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0005E045 File Offset: 0x0005C245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientUploadData);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0005E054 File Offset: 0x0005C254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientUploadData other)
		{
			return other != null && (other == this || (!(this.CIAFHFEFKOK != other.CIAFHFEFKOK) && !(this.Value != other.Value) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0005E0A8 File Offset: 0x0005C2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CIAFHFEFKOK.Length != 0)
			{
				num ^= this.CIAFHFEFKOK.GetHashCode();
			}
			if (this.Value.Length != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0005E104 File Offset: 0x0005C304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0005E10C File Offset: 0x0005C30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0005E118 File Offset: 0x0005C318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CIAFHFEFKOK.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.CIAFHFEFKOK);
			}
			if (this.Value.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0005E17C File Offset: 0x0005C37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CIAFHFEFKOK.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CIAFHFEFKOK);
			}
			if (this.Value.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0005E1DC File Offset: 0x0005C3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientUploadData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CIAFHFEFKOK.Length != 0)
			{
				this.CIAFHFEFKOK = other.CIAFHFEFKOK;
			}
			if (other.Value.Length != 0)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0005E236 File Offset: 0x0005C436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0005E240 File Offset: 0x0005C440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadString();
					}
				}
				else
				{
					this.CIAFHFEFKOK = input.ReadString();
				}
			}
		}

		// Token: 0x04000DA2 RID: 3490
		private static readonly MessageParser<ClientUploadData> _parser = new MessageParser<ClientUploadData>(() => new ClientUploadData());

		// Token: 0x04000DA3 RID: 3491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DA4 RID: 3492
		public const int CIAFHFEFKOKFieldNumber = 1;

		// Token: 0x04000DA5 RID: 3493
		private string cIAFHFEFKOK_ = "";

		// Token: 0x04000DA6 RID: 3494
		public const int ValueFieldNumber = 2;

		// Token: 0x04000DA7 RID: 3495
		private string value_ = "";
	}
}
