using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000007 RID: 7
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AbilityUseStt : IMessage<AbilityUseStt>, IMessage, IEquatable<AbilityUseStt>, IDeepCloneable<AbilityUseStt>, IBufferMessage
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000024B1 File Offset: 0x000006B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbilityUseStt> Parser
		{
			get
			{
				return AbilityUseStt._parser;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000024B8 File Offset: 0x000006B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AbilityUseSttReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000024CA File Offset: 0x000006CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbilityUseStt.Descriptor;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000024D1 File Offset: 0x000006D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbilityUseStt()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000024E4 File Offset: 0x000006E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbilityUseStt(AbilityUseStt other) : this()
		{
			this.aOMGNALLLGA_ = other.aOMGNALLLGA_;
			this.count_ = other.count_;
			this.totalDamage_ = other.totalDamage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002521 File Offset: 0x00000721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbilityUseStt Clone()
		{
			return new AbilityUseStt(this);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002529 File Offset: 0x00000729
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002531 File Offset: 0x00000731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AOMGNALLLGA
		{
			get
			{
				return this.aOMGNALLLGA_;
			}
			set
			{
				this.aOMGNALLLGA_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002544 File Offset: 0x00000744
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000254C File Offset: 0x0000074C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002555 File Offset: 0x00000755
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000255D File Offset: 0x0000075D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double TotalDamage
		{
			get
			{
				return this.totalDamage_;
			}
			set
			{
				this.totalDamage_ = value;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002566 File Offset: 0x00000766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbilityUseStt);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002574 File Offset: 0x00000774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbilityUseStt other)
		{
			return other != null && (other == this || (!(this.AOMGNALLLGA != other.AOMGNALLLGA) && this.Count == other.Count && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.TotalDamage, other.TotalDamage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000025DC File Offset: 0x000007DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AOMGNALLLGA.Length != 0)
			{
				num ^= this.AOMGNALLLGA.GetHashCode();
			}
			if (this.Count != 0U)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.TotalDamage != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.TotalDamage);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000265A File Offset: 0x0000085A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002662 File Offset: 0x00000862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000266C File Offset: 0x0000086C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AOMGNALLLGA.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AOMGNALLLGA);
			}
			if (this.Count != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Count);
			}
			if (this.TotalDamage != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.TotalDamage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000026F0 File Offset: 0x000008F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AOMGNALLLGA.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AOMGNALLLGA);
			}
			if (this.Count != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Count);
			}
			if (this.TotalDamage != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002764 File Offset: 0x00000964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbilityUseStt other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AOMGNALLLGA.Length != 0)
			{
				this.AOMGNALLLGA = other.AOMGNALLLGA;
			}
			if (other.Count != 0U)
			{
				this.Count = other.Count;
			}
			if (other.TotalDamage != 0.0)
			{
				this.TotalDamage = other.TotalDamage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000027D6 File Offset: 0x000009D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000027E0 File Offset: 0x000009E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 25U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalDamage = input.ReadDouble();
						}
					}
					else
					{
						this.Count = input.ReadUInt32();
					}
				}
				else
				{
					this.AOMGNALLLGA = input.ReadString();
				}
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly MessageParser<AbilityUseStt> _parser = new MessageParser<AbilityUseStt>(() => new AbilityUseStt());

		// Token: 0x04000012 RID: 18
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000013 RID: 19
		public const int AOMGNALLLGAFieldNumber = 1;

		// Token: 0x04000014 RID: 20
		private string aOMGNALLLGA_ = "";

		// Token: 0x04000015 RID: 21
		public const int CountFieldNumber = 2;

		// Token: 0x04000016 RID: 22
		private uint count_;

		// Token: 0x04000017 RID: 23
		public const int TotalDamageFieldNumber = 3;

		// Token: 0x04000018 RID: 24
		private double totalDamage_;
	}
}
