using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200007B RID: 123
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ALDDPHFCMGG : IMessage<ALDDPHFCMGG>, IMessage, IEquatable<ALDDPHFCMGG>, IDeepCloneable<ALDDPHFCMGG>, IBufferMessage
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0000F478 File Offset: 0x0000D678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ALDDPHFCMGG> Parser
		{
			get
			{
				return ALDDPHFCMGG._parser;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0000F47F File Offset: 0x0000D67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ALDDPHFCMGGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0000F491 File Offset: 0x0000D691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ALDDPHFCMGG.Descriptor;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000F498 File Offset: 0x0000D698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALDDPHFCMGG()
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000F4AB File Offset: 0x0000D6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALDDPHFCMGG(ALDDPHFCMGG other) : this()
		{
			this.value_ = other.value_;
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ALDDPHFCMGG Clone()
		{
			return new ALDDPHFCMGG(this);
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0000F4EC File Offset: 0x0000D6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0000F4F5 File Offset: 0x0000D6F5
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0000F4FD File Offset: 0x0000D6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000F510 File Offset: 0x0000D710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ALDDPHFCMGG);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000F520 File Offset: 0x0000D720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ALDDPHFCMGG other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Value, other.Value) && !(this.Key != other.Key) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000F578 File Offset: 0x0000D778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Value != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Value);
			}
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000F5D9 File Offset: 0x0000D7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000F5E1 File Offset: 0x0000D7E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Key);
			}
			if (this.Value != 0f)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000F650 File Offset: 0x0000D850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Value != 0f)
			{
				num += 5;
			}
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ALDDPHFCMGG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Value != 0f)
			{
				this.Value = other.Value;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000F6FE File Offset: 0x0000D8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000F708 File Offset: 0x0000D908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 109U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadFloat();
					}
				}
				else
				{
					this.Key = input.ReadString();
				}
			}
		}

		// Token: 0x040001F3 RID: 499
		private static readonly MessageParser<ALDDPHFCMGG> _parser = new MessageParser<ALDDPHFCMGG>(() => new ALDDPHFCMGG());

		// Token: 0x040001F4 RID: 500
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001F5 RID: 501
		public const int ValueFieldNumber = 13;

		// Token: 0x040001F6 RID: 502
		private float value_;

		// Token: 0x040001F7 RID: 503
		public const int KeyFieldNumber = 1;

		// Token: 0x040001F8 RID: 504
		private string key_ = "";
	}
}
