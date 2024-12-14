using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000911 RID: 2321
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ICDLIMEEGBC : IMessage<ICDLIMEEGBC>, IMessage, IEquatable<ICDLIMEEGBC>, IDeepCloneable<ICDLIMEEGBC>, IBufferMessage
	{
		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x0600678A RID: 26506 RVA: 0x00114D9C File Offset: 0x00112F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ICDLIMEEGBC> Parser
		{
			get
			{
				return ICDLIMEEGBC._parser;
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x00114DA3 File Offset: 0x00112FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ICDLIMEEGBCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x00114DB5 File Offset: 0x00112FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICDLIMEEGBC.Descriptor;
			}
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x00114DBC File Offset: 0x00112FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICDLIMEEGBC()
		{
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x00114DC4 File Offset: 0x00112FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICDLIMEEGBC(ICDLIMEEGBC other) : this()
		{
			this.areaId_ = other.areaId_;
			this.gJICPOLKKEN_ = other.gJICPOLKKEN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x00114DF5 File Offset: 0x00112FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICDLIMEEGBC Clone()
		{
			return new ICDLIMEEGBC(this);
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06006790 RID: 26512 RVA: 0x00114DFD File Offset: 0x00112FFD
		// (set) Token: 0x06006791 RID: 26513 RVA: 0x00114E05 File Offset: 0x00113005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06006792 RID: 26514 RVA: 0x00114E0E File Offset: 0x0011300E
		// (set) Token: 0x06006793 RID: 26515 RVA: 0x00114E16 File Offset: 0x00113016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GJICPOLKKEN
		{
			get
			{
				return this.gJICPOLKKEN_;
			}
			set
			{
				this.gJICPOLKKEN_ = value;
			}
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x00114E1F File Offset: 0x0011301F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICDLIMEEGBC);
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x00114E2D File Offset: 0x0011302D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICDLIMEEGBC other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.GJICPOLKKEN == other.GJICPOLKKEN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x00114E6C File Offset: 0x0011306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.GJICPOLKKEN != 0U)
			{
				num ^= this.GJICPOLKKEN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x00114EC4 File Offset: 0x001130C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00114ECC File Offset: 0x001130CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x00114ED8 File Offset: 0x001130D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AreaId);
			}
			if (this.GJICPOLKKEN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GJICPOLKKEN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x00114F34 File Offset: 0x00113134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.GJICPOLKKEN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GJICPOLKKEN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x00114F8C File Offset: 0x0011318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICDLIMEEGBC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.GJICPOLKKEN != 0U)
			{
				this.GJICPOLKKEN = other.GJICPOLKKEN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x00114FDC File Offset: 0x001131DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x00114FE8 File Offset: 0x001131E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GJICPOLKKEN = input.ReadUInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040027CC RID: 10188
		private static readonly MessageParser<ICDLIMEEGBC> _parser = new MessageParser<ICDLIMEEGBC>(() => new ICDLIMEEGBC());

		// Token: 0x040027CD RID: 10189
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027CE RID: 10190
		public const int AreaIdFieldNumber = 4;

		// Token: 0x040027CF RID: 10191
		private uint areaId_;

		// Token: 0x040027D0 RID: 10192
		public const int GJICPOLKKENFieldNumber = 14;

		// Token: 0x040027D1 RID: 10193
		private uint gJICPOLKKEN_;
	}
}
