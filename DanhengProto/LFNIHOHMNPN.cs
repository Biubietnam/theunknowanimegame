using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A0B RID: 2571
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LFNIHOHMNPN : IMessage<LFNIHOHMNPN>, IMessage, IEquatable<LFNIHOHMNPN>, IDeepCloneable<LFNIHOHMNPN>, IBufferMessage
	{
		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06007216 RID: 29206 RVA: 0x0012F6CD File Offset: 0x0012D8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LFNIHOHMNPN> Parser
		{
			get
			{
				return LFNIHOHMNPN._parser;
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06007217 RID: 29207 RVA: 0x0012F6D4 File Offset: 0x0012D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LFNIHOHMNPNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06007218 RID: 29208 RVA: 0x0012F6E6 File Offset: 0x0012D8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LFNIHOHMNPN.Descriptor;
			}
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x0012F6ED File Offset: 0x0012D8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LFNIHOHMNPN()
		{
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x0012F6F5 File Offset: 0x0012D8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LFNIHOHMNPN(LFNIHOHMNPN other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.displayValue_ = other.displayValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x0012F732 File Offset: 0x0012D932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LFNIHOHMNPN Clone()
		{
			return new LFNIHOHMNPN(this);
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x0600721C RID: 29212 RVA: 0x0012F73A File Offset: 0x0012D93A
		// (set) Token: 0x0600721D RID: 29213 RVA: 0x0012F742 File Offset: 0x0012D942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionSyncRecord Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x0600721E RID: 29214 RVA: 0x0012F74B File Offset: 0x0012D94B
		// (set) Token: 0x0600721F RID: 29215 RVA: 0x0012F753 File Offset: 0x0012D953
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

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06007220 RID: 29216 RVA: 0x0012F75C File Offset: 0x0012D95C
		// (set) Token: 0x06007221 RID: 29217 RVA: 0x0012F764 File Offset: 0x0012D964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DisplayValue
		{
			get
			{
				return this.displayValue_;
			}
			set
			{
				this.displayValue_ = value;
			}
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x0012F76D File Offset: 0x0012D96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LFNIHOHMNPN);
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x0012F77C File Offset: 0x0012D97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LFNIHOHMNPN other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && this.DisplayValue == other.DisplayValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x0012F7D8 File Offset: 0x0012D9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != MissionSyncRecord.None)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.DisplayValue != 0U)
			{
				num ^= this.DisplayValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x0012F84F File Offset: 0x0012DA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x0012F857 File Offset: 0x0012DA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x0012F860 File Offset: 0x0012DA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			if (this.DisplayValue != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.DisplayValue);
			}
			if (this.Type != MissionSyncRecord.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x0012F8D8 File Offset: 0x0012DAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != MissionSyncRecord.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.DisplayValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DisplayValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x0012F948 File Offset: 0x0012DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LFNIHOHMNPN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != MissionSyncRecord.None)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.DisplayValue != 0U)
			{
				this.DisplayValue = other.DisplayValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x0012F9AC File Offset: 0x0012DBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x0012F9B8 File Offset: 0x0012DBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Type = (MissionSyncRecord)input.ReadEnum();
						}
					}
					else
					{
						this.DisplayValue = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002BD3 RID: 11219
		private static readonly MessageParser<LFNIHOHMNPN> _parser = new MessageParser<LFNIHOHMNPN>(() => new LFNIHOHMNPN());

		// Token: 0x04002BD4 RID: 11220
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BD5 RID: 11221
		public const int TypeFieldNumber = 9;

		// Token: 0x04002BD6 RID: 11222
		private MissionSyncRecord type_;

		// Token: 0x04002BD7 RID: 11223
		public const int IdFieldNumber = 2;

		// Token: 0x04002BD8 RID: 11224
		private uint id_;

		// Token: 0x04002BD9 RID: 11225
		public const int DisplayValueFieldNumber = 4;

		// Token: 0x04002BDA RID: 11226
		private uint displayValue_;
	}
}
