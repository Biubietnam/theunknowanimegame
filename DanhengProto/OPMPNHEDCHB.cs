using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C77 RID: 3191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OPMPNHEDCHB : IMessage<OPMPNHEDCHB>, IMessage, IEquatable<OPMPNHEDCHB>, IDeepCloneable<OPMPNHEDCHB>, IBufferMessage
	{
		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x06008DD1 RID: 36305 RVA: 0x00176CD4 File Offset: 0x00174ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OPMPNHEDCHB> Parser
		{
			get
			{
				return OPMPNHEDCHB._parser;
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x06008DD2 RID: 36306 RVA: 0x00176CDB File Offset: 0x00174EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OPMPNHEDCHBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x06008DD3 RID: 36307 RVA: 0x00176CED File Offset: 0x00174EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OPMPNHEDCHB.Descriptor;
			}
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x00176CF4 File Offset: 0x00174EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPMPNHEDCHB()
		{
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x00176CFC File Offset: 0x00174EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPMPNHEDCHB(OPMPNHEDCHB other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x00176D2D File Offset: 0x00174F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPMPNHEDCHB Clone()
		{
			return new OPMPNHEDCHB(this);
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x06008DD7 RID: 36311 RVA: 0x00176D35 File Offset: 0x00174F35
		// (set) Token: 0x06008DD8 RID: 36312 RVA: 0x00176D3D File Offset: 0x00174F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x06008DD9 RID: 36313 RVA: 0x00176D46 File Offset: 0x00174F46
		// (set) Token: 0x06008DDA RID: 36314 RVA: 0x00176D4E File Offset: 0x00174F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x06008DDB RID: 36315 RVA: 0x00176D57 File Offset: 0x00174F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OPMPNHEDCHB);
		}

		// Token: 0x06008DDC RID: 36316 RVA: 0x00176D65 File Offset: 0x00174F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OPMPNHEDCHB other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x00176DA4 File Offset: 0x00174FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0U)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x00176DFC File Offset: 0x00174FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DDF RID: 36319 RVA: 0x00176E04 File Offset: 0x00175004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x00176E10 File Offset: 0x00175010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemCount != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ItemCount);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DE1 RID: 36321 RVA: 0x00176E6C File Offset: 0x0017506C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x00176EC4 File Offset: 0x001750C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OPMPNHEDCHB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0U)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x00176F14 File Offset: 0x00175114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x00176F20 File Offset: 0x00175120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemId = input.ReadUInt32();
					}
				}
				else
				{
					this.ItemCount = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003673 RID: 13939
		private static readonly MessageParser<OPMPNHEDCHB> _parser = new MessageParser<OPMPNHEDCHB>(() => new OPMPNHEDCHB());

		// Token: 0x04003674 RID: 13940
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003675 RID: 13941
		public const int ItemIdFieldNumber = 15;

		// Token: 0x04003676 RID: 13942
		private uint itemId_;

		// Token: 0x04003677 RID: 13943
		public const int ItemCountFieldNumber = 3;

		// Token: 0x04003678 RID: 13944
		private uint itemCount_;
	}
}
