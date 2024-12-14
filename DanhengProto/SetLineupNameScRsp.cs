using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001113 RID: 4371
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetLineupNameScRsp : IMessage<SetLineupNameScRsp>, IMessage, IEquatable<SetLineupNameScRsp>, IDeepCloneable<SetLineupNameScRsp>, IBufferMessage
	{
		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600C2E4 RID: 49892 RVA: 0x0020B470 File Offset: 0x00209670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetLineupNameScRsp> Parser
		{
			get
			{
				return SetLineupNameScRsp._parser;
			}
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600C2E5 RID: 49893 RVA: 0x0020B477 File Offset: 0x00209677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetLineupNameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600C2E6 RID: 49894 RVA: 0x0020B489 File Offset: 0x00209689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetLineupNameScRsp.Descriptor;
			}
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x0020B490 File Offset: 0x00209690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLineupNameScRsp()
		{
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x0020B4A3 File Offset: 0x002096A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLineupNameScRsp(SetLineupNameScRsp other) : this()
		{
			this.name_ = other.name_;
			this.index_ = other.index_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x0020B4E0 File Offset: 0x002096E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetLineupNameScRsp Clone()
		{
			return new SetLineupNameScRsp(this);
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600C2EA RID: 49898 RVA: 0x0020B4E8 File Offset: 0x002096E8
		// (set) Token: 0x0600C2EB RID: 49899 RVA: 0x0020B4F0 File Offset: 0x002096F0
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

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600C2EC RID: 49900 RVA: 0x0020B503 File Offset: 0x00209703
		// (set) Token: 0x0600C2ED RID: 49901 RVA: 0x0020B50B File Offset: 0x0020970B
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

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600C2EE RID: 49902 RVA: 0x0020B514 File Offset: 0x00209714
		// (set) Token: 0x0600C2EF RID: 49903 RVA: 0x0020B51C File Offset: 0x0020971C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600C2F0 RID: 49904 RVA: 0x0020B525 File Offset: 0x00209725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetLineupNameScRsp);
		}

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x0020B534 File Offset: 0x00209734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetLineupNameScRsp other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.Index == other.Index && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2F2 RID: 49906 RVA: 0x0020B594 File Offset: 0x00209794
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
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x0020B607 File Offset: 0x00209807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C2F4 RID: 49908 RVA: 0x0020B60F File Offset: 0x0020980F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2F5 RID: 49909 RVA: 0x0020B618 File Offset: 0x00209818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Index != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2F6 RID: 49910 RVA: 0x0020B694 File Offset: 0x00209894
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
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2F7 RID: 49911 RVA: 0x0020B708 File Offset: 0x00209908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetLineupNameScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2F8 RID: 49912 RVA: 0x0020B771 File Offset: 0x00209971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x0020B77C File Offset: 0x0020997C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 48U)
					{
						if (num != 104U)
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
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04004EC9 RID: 20169
		private static readonly MessageParser<SetLineupNameScRsp> _parser = new MessageParser<SetLineupNameScRsp>(() => new SetLineupNameScRsp());

		// Token: 0x04004ECA RID: 20170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ECB RID: 20171
		public const int NameFieldNumber = 4;

		// Token: 0x04004ECC RID: 20172
		private string name_ = "";

		// Token: 0x04004ECD RID: 20173
		public const int IndexFieldNumber = 13;

		// Token: 0x04004ECE RID: 20174
		private uint index_;

		// Token: 0x04004ECF RID: 20175
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04004ED0 RID: 20176
		private uint retcode_;
	}
}
