using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AAB RID: 2731
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Material : IMessage<Material>, IMessage, IEquatable<Material>, IDeepCloneable<Material>, IBufferMessage
	{
		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x0600790B RID: 30987 RVA: 0x00140CC4 File Offset: 0x0013EEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Material> Parser
		{
			get
			{
				return Material._parser;
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600790C RID: 30988 RVA: 0x00140CCB File Offset: 0x0013EECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MaterialReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600790D RID: 30989 RVA: 0x00140CDD File Offset: 0x0013EEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Material.Descriptor;
			}
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x00140CE4 File Offset: 0x0013EEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Material()
		{
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x00140CEC File Offset: 0x0013EEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Material(Material other) : this()
		{
			this.tid_ = other.tid_;
			this.num_ = other.num_;
			this.expireTime_ = other.expireTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x00140D29 File Offset: 0x0013EF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Material Clone()
		{
			return new Material(this);
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06007911 RID: 30993 RVA: 0x00140D31 File Offset: 0x0013EF31
		// (set) Token: 0x06007912 RID: 30994 RVA: 0x00140D39 File Offset: 0x0013EF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06007913 RID: 30995 RVA: 0x00140D42 File Offset: 0x0013EF42
		// (set) Token: 0x06007914 RID: 30996 RVA: 0x00140D4A File Offset: 0x0013EF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06007915 RID: 30997 RVA: 0x00140D53 File Offset: 0x0013EF53
		// (set) Token: 0x06007916 RID: 30998 RVA: 0x00140D5B File Offset: 0x0013EF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong ExpireTime
		{
			get
			{
				return this.expireTime_;
			}
			set
			{
				this.expireTime_ = value;
			}
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x00140D64 File Offset: 0x0013EF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Material);
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x00140D74 File Offset: 0x0013EF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Material other)
		{
			return other != null && (other == this || (this.Tid == other.Tid && this.Num == other.Num && this.ExpireTime == other.ExpireTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x00140DD0 File Offset: 0x0013EFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.ExpireTime != 0UL)
			{
				num ^= this.ExpireTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x00140E41 File Offset: 0x0013F041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x00140E49 File Offset: 0x0013F049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x00140E54 File Offset: 0x0013F054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExpireTime != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.ExpireTime);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Num);
			}
			if (this.Tid != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Tid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x00140ECC File Offset: 0x0013F0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this.ExpireTime != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpireTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x00140F3C File Offset: 0x0013F13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Material other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			if (other.ExpireTime != 0UL)
			{
				this.ExpireTime = other.ExpireTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00140FA0 File Offset: 0x0013F1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00140FAC File Offset: 0x0013F1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Tid = input.ReadUInt32();
						}
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.ExpireTime = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04002E76 RID: 11894
		private static readonly MessageParser<Material> _parser = new MessageParser<Material>(() => new Material());

		// Token: 0x04002E77 RID: 11895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E78 RID: 11896
		public const int TidFieldNumber = 15;

		// Token: 0x04002E79 RID: 11897
		private uint tid_;

		// Token: 0x04002E7A RID: 11898
		public const int NumFieldNumber = 10;

		// Token: 0x04002E7B RID: 11899
		private uint num_;

		// Token: 0x04002E7C RID: 11900
		public const int ExpireTimeFieldNumber = 6;

		// Token: 0x04002E7D RID: 11901
		private ulong expireTime_;
	}
}
