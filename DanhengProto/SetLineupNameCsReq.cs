using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001111 RID: 4369
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetLineupNameCsReq : IMessage<SetLineupNameCsReq>, IMessage, IEquatable<SetLineupNameCsReq>, IDeepCloneable<SetLineupNameCsReq>, IBufferMessage
	{
		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600C2CD RID: 49869 RVA: 0x0020B100 File Offset: 0x00209300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetLineupNameCsReq> Parser
		{
			get
			{
				return SetLineupNameCsReq._parser;
			}
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600C2CE RID: 49870 RVA: 0x0020B107 File Offset: 0x00209307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetLineupNameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600C2CF RID: 49871 RVA: 0x0020B119 File Offset: 0x00209319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetLineupNameCsReq.Descriptor;
			}
		}

		// Token: 0x0600C2D0 RID: 49872 RVA: 0x0020B120 File Offset: 0x00209320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLineupNameCsReq()
		{
		}

		// Token: 0x0600C2D1 RID: 49873 RVA: 0x0020B133 File Offset: 0x00209333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLineupNameCsReq(SetLineupNameCsReq other) : this()
		{
			this.name_ = other.name_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x0020B164 File Offset: 0x00209364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLineupNameCsReq Clone()
		{
			return new SetLineupNameCsReq(this);
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600C2D3 RID: 49875 RVA: 0x0020B16C File Offset: 0x0020936C
		// (set) Token: 0x0600C2D4 RID: 49876 RVA: 0x0020B174 File Offset: 0x00209374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600C2D5 RID: 49877 RVA: 0x0020B187 File Offset: 0x00209387
		// (set) Token: 0x0600C2D6 RID: 49878 RVA: 0x0020B18F File Offset: 0x0020938F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x0020B198 File Offset: 0x00209398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetLineupNameCsReq);
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x0020B1A8 File Offset: 0x002093A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetLineupNameCsReq other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x0020B1F8 File Offset: 0x002093F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Index != 0U)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x0020B252 File Offset: 0x00209452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C2DB RID: 49883 RVA: 0x0020B25A File Offset: 0x0020945A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x0020B264 File Offset: 0x00209464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x0020B2C4 File Offset: 0x002094C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Index != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x0020B320 File Offset: 0x00209520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetLineupNameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Index != 0U)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x0020B375 File Offset: 0x00209575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2E0 RID: 49888 RVA: 0x0020B380 File Offset: 0x00209580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadUInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04004EC2 RID: 20162
		private static readonly MessageParser<SetLineupNameCsReq> _parser = new MessageParser<SetLineupNameCsReq>(() => new SetLineupNameCsReq());

		// Token: 0x04004EC3 RID: 20163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EC4 RID: 20164
		public const int NameFieldNumber = 2;

		// Token: 0x04004EC5 RID: 20165
		private string name_ = "";

		// Token: 0x04004EC6 RID: 20166
		public const int IndexFieldNumber = 9;

		// Token: 0x04004EC7 RID: 20167
		private uint index_;
	}
}
